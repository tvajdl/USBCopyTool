using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace USBCopy_v2
{
    public partial class FormMain : Form
    {
        private static ManagementEventWatcher watcherUSBArrival = new ManagementEventWatcher();
        private static ManagementEventWatcher watcherUSBRemoval = new ManagementEventWatcher();

        private static List<DriveInfo> drives;
        private FormWorking formWorking;

        private bool cancel = false;

        public FormMain()
        {
            this.Icon = USBCopyTool.Properties.Resources.usbicon;
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

            

            watcherUSBArrival.EventArrived += new EventArrivedEventHandler(watcherUSBArrival_EventArrived);
            watcherUSBArrival.Query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2"); //device arrival
            watcherUSBArrival.Start();
            ThreadPool.QueueUserWorkItem(new WaitCallback(USBArrivalWatcher));

            watcherUSBRemoval.EventArrived += new EventArrivedEventHandler(watcherUSBRemoval_EventArrived);
            watcherUSBRemoval.Query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 3"); //device removal
            watcherUSBRemoval.Start();
            ThreadPool.QueueUserWorkItem(new WaitCallback(USBRemovalWatcher));

            refreshDriveList();

        }

        private void refreshDriveList()
        {
            textBoxUSB.Clear();
            drives = DriveInfo.GetDrives().ToList<DriveInfo>(); //trenutno vtaknjeni pogoni
            List<DriveInfo> vsiPogoni = DriveInfo.GetDrives().ToList();
            foreach (var usb in vsiPogoni)
            {
                if (usb.DriveType == DriveType.Removable && usb.IsReady)
                {
                    AppendTextBox(1, usb.RootDirectory.Name, 1);
                }
            }
        }

        private void watcherUSBRemoval_EventArrived(object sender, EventArrivedEventArgs e)
        {
            DriveInfo removed = drives.Except(DriveInfo.GetDrives().ToList<DriveInfo>(), new DriveInfoComparer()).ToList().ElementAt(0);


            if (removed != null)
            {
                AppendTextBox(1, removed.RootDirectory.FullName, 2);
            }
            //posodobi seznam trenutno vtaknjenih pogonov
            drives = DriveInfo.GetDrives().ToList<DriveInfo>();
        }

        private static void USBRemovalWatcher(object obj)
        {
            //watcher.Start();
            watcherUSBRemoval.WaitForNextEvent();
        }

        //comparer class za .Except() metodo, ker brez tega slabo razlikuje med objekti
        private class DriveInfoComparer : IEqualityComparer<DriveInfo>
        {
            public int GetHashCode(DriveInfo drive)
            {
                return drive.RootDirectory.FullName.GetHashCode(); //iz imena naredi unikatni integer za primerjavo
            }

            public bool Equals(DriveInfo drive1, DriveInfo drive2) //kaj primerja
            {
                return drive1.RootDirectory.FullName == drive2.RootDirectory.FullName;
            }

        }

        private void watcherUSBArrival_EventArrived(object sender, EventArrivedEventArgs e)
        {
            List<DriveInfo> vsiPogoni = DriveInfo.GetDrives().ToList<DriveInfo>();
            List<DriveInfo> pogon = vsiPogoni.Except(drives, new DriveInfoComparer()).ToList(); //dobi tisti pogon, kateri prej ni bil notri priklopljen
                                                                                                //vsiPogoni.Except()
            if (pogon.Count > 0)
            {
                var usb = pogon.ElementAt(0);
                drives.Add(usb);
                if (usb.DriveType == DriveType.Removable && usb.IsReady)
                {
                    AppendTextBox(1, usb.RootDirectory.FullName, 1);

                    /*
                    string root = usb.RootDirectory.FullName;
                    string source = textBoxBrowse.Text;
                    string destination = usb.RootDirectory.FullName + Path.GetFileName(textBoxBrowse.Text);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(CopyMethod), new object[] { root, source, destination });
                    */
                }

            }

        }

        private static void USBArrivalWatcher(object obj)
        {
            //watcher.Start();
            watcherUSBArrival.WaitForNextEvent();

        }



        //da se lahko posodablja UI iz drugega threada
        public void AppendTextBox(int textbox, string value, int action=0, string value2="")
        {
            /*
             textbox:
            1 - textBoxUSB
            2 - textBoxOutput
             */


            if (InvokeRequired)
            {
                this.Invoke(new Action<int, string, int, string>(AppendTextBox), new object[] { textbox, value, action, value2});
                return;
            }
            if (textbox == 1)
            {
                switch (action)
                {

                    case 1: //append
                        { textBoxUSB.AppendText(value + Environment.NewLine); }
                        break;

                    case 2: //find and delete
                        {
                            List<string> lines = new List<string>(textBoxUSB.Lines);
                            lines.Remove(value);

                            lines.RemoveAll(str => str.Contains(value));


                            textBoxUSB.Lines = lines.ToArray();

                        }
                        break;
                    case 3: //find and replace
                        {
                            List<string> lines = new List<string>(textBoxUSB.Lines);
                            lines[lines.FindIndex(str => str.StartsWith(value))] = value2;
                            textBoxUSB.Lines = lines.ToArray();
                        }
                        break;
                    default:
                        { }
                        break;
                }
            }
            else if (textbox == 2)
            {
                textBoxOutput.AppendText(value + value2);
            }
        }

        public void FormatDrive(object obj)
        {
            //izpiše vse USBje, ki so ob zagonu programa že v računalniku
            List<DriveInfo> vsiPogoni = DriveInfo.GetDrives().ToList<DriveInfo>();
            List<DriveInfo> pogon = vsiPogoni.ToList();

            

            foreach (var usb in pogon)
            {
                
                if (cancel)
                {
                    cancel = false;
                    AppendTextBox(2, "Formatiranje preklicano" + Environment.NewLine);
                    return;
                }
                
                if (usb.DriveType == DriveType.Removable && usb.IsReady)
                {
                    if (usb.RootDirectory.Name.Length > 0)
                    {
                        if (FormatDrive_CommandLine((char)usb.RootDirectory.Name[0], "USB", "FAT32"))
                        {
                            //ok
                            AppendTextBox(2, usb.RootDirectory.Name[0].ToString(), 3, " - formatiran" + Environment.NewLine);
                        }
                        else
                        {
                            //fail
                            AppendTextBox(2, usb.RootDirectory.Name[0].ToString(), 3, " - format napaka" + Environment.NewLine);
                        }
                    }
                }
            }
            
            AppendTextBox(2, "Formatiranje končano! " + Environment.NewLine);


            if (this.formWorking.InvokeRequired)
            {
                formWorking.Invoke(new MethodInvoker(delegate { formWorking.Close(); }));
            }
            else
            {
                formWorking.Close();
            }

            return;
        }

        //metoda za formatiranje 
        public static bool FormatDrive_CommandLine(char driveLetter, string label = "", string fileSystem = "NTFS", bool quickFormat = true, bool enableCompression = false, int? clusterSize = null)
        {
            #region args check

            #endregion
            bool success = false;
            string drive = driveLetter + ":";
            try
            {
                var di = new DriveInfo(drive);
                var psi = new ProcessStartInfo();
                psi.FileName = "format.com";
                psi.WorkingDirectory = Environment.SystemDirectory;
                psi.Arguments = "/FS:" + fileSystem +
                                             " /Y" +
                                             " /V:" + label +
                                             (quickFormat ? " /Q" : "") +
                                             ((fileSystem == "NTFS" && enableCompression) ? " /C" : "") +
                                             (clusterSize.HasValue ? " /A:" + clusterSize.Value : "") +
                                             " " + drive;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true; //if you want to hide the window
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardInput = true;
                var formatProcess = Process.Start(psi);
                var swStandardInput = formatProcess.StandardInput;
                swStandardInput.WriteLine();
                formatProcess.WaitForExit();
                success = true;
            }
            catch (Exception) { }
            return success;
        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            cancel = false;
            textBoxOutput.AppendText("Formatiranje ..." + Environment.NewLine);

            ThreadPool.QueueUserWorkItem(new WaitCallback(FormatDrive));
            formWorking = new FormWorking("Formatiranje...");
            
            if (formWorking.ShowDialog() == DialogResult.Cancel)
            {
                cancel = true;
            }
            
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialogBrowse.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialogBrowse.ShowDialog() == DialogResult.OK)
            {
                textBoxBrowse.Text = openFileDialogBrowse.SafeFileName;
                
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFileDialogBrowse.FileName))
            {
                List<DriveInfo> vsiPogoni = DriveInfo.GetDrives().ToList<DriveInfo>();
                List<DriveInfo> pogon = vsiPogoni.ToList();
                foreach (var usb in pogon)
                {
                    if (usb.DriveType == DriveType.Removable && usb.IsReady)
                    {

                        string root = usb.RootDirectory.Name;
                        string source = openFileDialogBrowse.FileName;
                        string destination = usb.RootDirectory.Name + Path.GetFileName(openFileDialogBrowse.FileName);
                        ThreadPool.QueueUserWorkItem(new WaitCallback(CopyMethod), new object[] { root, source, destination });

                    }
                }
            }
            else MessageBox.Show("Datoteka ne obstaja!");
        }

        public void CopyMethod(object obj)
        {
            object[] array = obj as object[];
            string root = (string)array[0];
            string source = (string)array[1];
            string destination = (string)array[2];
            //MessageBox.Show(destination);

            FileSystem.CopyFile(source, destination, UIOption.AllDialogs);
            AppendTextBox(2, root, 3, " kopirano" + Environment.NewLine);


        }

        private void buttonEject_Click(object sender, EventArgs e)
        {
            cancel = false;
            ThreadPool.QueueUserWorkItem(new WaitCallback(EjectMethod));
            formWorking = new FormWorking("Varno odstranjevanje...");
            
            if (formWorking.ShowDialog() == DialogResult.Cancel)
            {
                cancel = true;
            }
            refreshDriveList();
        }

        public void EjectMethod(object obj)
        {
            List<DriveInfo> vsiPogoni = DriveInfo.GetDrives().ToList<DriveInfo>();
            List<DriveInfo> pogon = vsiPogoni.ToList();
            foreach (var usb in pogon)
            {
                
                if (cancel)
                {
                    cancel = false;
                    AppendTextBox(2, "Varno odstranjevanje preklicano" + Environment.NewLine);
                    return;
                }
                
                if (usb.DriveType == DriveType.Removable && usb.IsReady)
                {
                    string tmp = usb.RootDirectory.Name;
                    USBEject a = new USBEject(usb.RootDirectory.Name.Replace(@"\", ""));
                    if (a.Eject())
                    {
                        //textBoxOutput.AppendText(tmp + " odstranjen" + Environment.NewLine);

                        AppendTextBox(2, tmp + " odstranjen" + Environment.NewLine);
                    }
                }
            }

            if (this.formWorking.InvokeRequired)
            {
                formWorking.Invoke(new MethodInvoker(delegate { formWorking.Close(); }));
            }
            else
            {
                formWorking.Close();
            }

        }

        private void buttonRefreshUSB_Click(object sender, EventArgs e)
        {
            refreshDriveList();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }
    }
}

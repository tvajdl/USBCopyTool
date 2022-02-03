
namespace USBCopy_v2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonFormat = new System.Windows.Forms.Button();
            this.buttonEject = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxUSB = new System.Windows.Forms.TextBox();
            this.textBoxBrowse = new System.Windows.Forms.TextBox();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.labelFormatAll = new System.Windows.Forms.Label();
            this.groupBoxBrowseCopy = new System.Windows.Forms.GroupBox();
            this.labelBrowse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEject = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.openFileDialogBrowse = new System.Windows.Forms.OpenFileDialog();
            this.buttonRefreshUSB = new System.Windows.Forms.Button();
            this.groupBoxUSB = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelInstructions2 = new System.Windows.Forms.Label();
            this.menuStripAbout = new System.Windows.Forms.MenuStrip();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFormat.SuspendLayout();
            this.groupBoxBrowseCopy.SuspendLayout();
            this.groupBoxEject.SuspendLayout();
            this.groupBoxUSB.SuspendLayout();
            this.menuStripAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFormat
            // 
            this.buttonFormat.Location = new System.Drawing.Point(5, 11);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(173, 23);
            this.buttonFormat.TabIndex = 0;
            this.buttonFormat.Text = "Formatiraj";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // buttonEject
            // 
            this.buttonEject.Location = new System.Drawing.Point(5, 13);
            this.buttonEject.Name = "buttonEject";
            this.buttonEject.Size = new System.Drawing.Size(167, 23);
            this.buttonEject.TabIndex = 1;
            this.buttonEject.Text = "Varno odstrani";
            this.buttonEject.UseVisualStyleBackColor = true;
            this.buttonEject.Click += new System.EventHandler(this.buttonEject_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(5, 11);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(173, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Prebrskaj";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(5, 66);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(173, 23);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "Kopiraj";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxUSB
            // 
            this.textBoxUSB.Enabled = false;
            this.textBoxUSB.Location = new System.Drawing.Point(6, 48);
            this.textBoxUSB.Multiline = true;
            this.textBoxUSB.Name = "textBoxUSB";
            this.textBoxUSB.Size = new System.Drawing.Size(117, 257);
            this.textBoxUSB.TabIndex = 4;
            // 
            // textBoxBrowse
            // 
            this.textBoxBrowse.Enabled = false;
            this.textBoxBrowse.Location = new System.Drawing.Point(6, 40);
            this.textBoxBrowse.Name = "textBoxBrowse";
            this.textBoxBrowse.Size = new System.Drawing.Size(172, 20);
            this.textBoxBrowse.TabIndex = 6;
            this.textBoxBrowse.Text = "Pot do datoteke...";
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFormat.Controls.Add(this.buttonFormat);
            this.groupBoxFormat.Controls.Add(this.labelFormatAll);
            this.groupBoxFormat.Location = new System.Drawing.Point(151, 140);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Size = new System.Drawing.Size(375, 42);
            this.groupBoxFormat.TabIndex = 7;
            this.groupBoxFormat.TabStop = false;
            // 
            // labelFormatAll
            // 
            this.labelFormatAll.AutoSize = true;
            this.labelFormatAll.Location = new System.Drawing.Point(184, 16);
            this.labelFormatAll.Name = "labelFormatAll";
            this.labelFormatAll.Size = new System.Drawing.Size(121, 13);
            this.labelFormatAll.TabIndex = 12;
            this.labelFormatAll.Text = "<- Formatiraj vse ključke";
            // 
            // groupBoxBrowseCopy
            // 
            this.groupBoxBrowseCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBrowseCopy.Controls.Add(this.labelBrowse);
            this.groupBoxBrowseCopy.Controls.Add(this.label1);
            this.groupBoxBrowseCopy.Controls.Add(this.textBoxBrowse);
            this.groupBoxBrowseCopy.Controls.Add(this.buttonBrowse);
            this.groupBoxBrowseCopy.Controls.Add(this.buttonCopy);
            this.groupBoxBrowseCopy.Location = new System.Drawing.Point(151, 188);
            this.groupBoxBrowseCopy.Name = "groupBoxBrowseCopy";
            this.groupBoxBrowseCopy.Size = new System.Drawing.Size(375, 96);
            this.groupBoxBrowseCopy.TabIndex = 8;
            this.groupBoxBrowseCopy.TabStop = false;
            // 
            // labelBrowse
            // 
            this.labelBrowse.AutoSize = true;
            this.labelBrowse.Location = new System.Drawing.Point(184, 12);
            this.labelBrowse.Name = "labelBrowse";
            this.labelBrowse.Size = new System.Drawing.Size(193, 26);
            this.labelBrowse.TabIndex = 13;
            this.labelBrowse.Text = "<- Izberi datoteko za kopirat na ključke.\r\n    Datoteka naj NE BO na T disku!";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(184, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "<- Kopiraj izbrano datoteko na ključke";
            // 
            // groupBoxEject
            // 
            this.groupBoxEject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEject.Controls.Add(this.label2);
            this.groupBoxEject.Controls.Add(this.buttonEject);
            this.groupBoxEject.Location = new System.Drawing.Point(151, 290);
            this.groupBoxEject.Name = "groupBoxEject";
            this.groupBoxEject.Size = new System.Drawing.Size(375, 42);
            this.groupBoxEject.TabIndex = 10;
            this.groupBoxEject.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "<- Varno odstrani ključke";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(12, 346);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(515, 137);
            this.textBoxOutput.TabIndex = 11;
            // 
            // openFileDialogBrowse
            // 
            this.openFileDialogBrowse.FileName = "openFileDialog1";
            // 
            // buttonRefreshUSB
            // 
            this.buttonRefreshUSB.Location = new System.Drawing.Point(6, 19);
            this.buttonRefreshUSB.Name = "buttonRefreshUSB";
            this.buttonRefreshUSB.Size = new System.Drawing.Size(117, 23);
            this.buttonRefreshUSB.TabIndex = 12;
            this.buttonRefreshUSB.Text = "Osveži seznam";
            this.buttonRefreshUSB.UseVisualStyleBackColor = true;
            this.buttonRefreshUSB.Click += new System.EventHandler(this.buttonRefreshUSB_Click);
            // 
            // groupBoxUSB
            // 
            this.groupBoxUSB.Controls.Add(this.textBoxUSB);
            this.groupBoxUSB.Controls.Add(this.buttonRefreshUSB);
            this.groupBoxUSB.Location = new System.Drawing.Point(12, 21);
            this.groupBoxUSB.Name = "groupBoxUSB";
            this.groupBoxUSB.Size = new System.Drawing.Size(129, 311);
            this.groupBoxUSB.TabIndex = 13;
            this.groupBoxUSB.TabStop = false;
            this.groupBoxUSB.Text = "Najdeni USB";
            // 
            // labelInstructions
            // 
            this.labelInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(145, 9);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(296, 32);
            this.labelInstructions.TabIndex = 14;
            this.labelInstructions.Text = "Navodila za uporabo:";
            // 
            // labelInstructions2
            // 
            this.labelInstructions2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInstructions2.AutoSize = true;
            this.labelInstructions2.Location = new System.Drawing.Point(148, 49);
            this.labelInstructions2.Name = "labelInstructions2";
            this.labelInstructions2.Size = new System.Drawing.Size(326, 91);
            this.labelInstructions2.TabIndex = 15;
            this.labelInstructions2.Text = resources.GetString("labelInstructions2.Text");
            // 
            // menuStripAbout
            // 
            this.menuStripAbout.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripAbout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStripAbout.Location = new System.Drawing.Point(0, 0);
            this.menuStripAbout.Name = "menuStripAbout";
            this.menuStripAbout.Size = new System.Drawing.Size(539, 24);
            this.menuStripAbout.TabIndex = 16;
            this.menuStripAbout.Text = "menuStrip1";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 495);
            this.Controls.Add(this.labelInstructions2);
            this.Controls.Add(this.groupBoxUSB);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.groupBoxEject);
            this.Controls.Add(this.groupBoxBrowseCopy);
            this.Controls.Add(this.groupBoxFormat);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.menuStripAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(555, 534);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Copy Tool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.groupBoxBrowseCopy.ResumeLayout(false);
            this.groupBoxBrowseCopy.PerformLayout();
            this.groupBoxEject.ResumeLayout(false);
            this.groupBoxEject.PerformLayout();
            this.groupBoxUSB.ResumeLayout(false);
            this.groupBoxUSB.PerformLayout();
            this.menuStripAbout.ResumeLayout(false);
            this.menuStripAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.Button buttonEject;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxUSB;
        private System.Windows.Forms.TextBox textBoxBrowse;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.GroupBox groupBoxBrowseCopy;
        private System.Windows.Forms.GroupBox groupBoxEject;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFormatAll;
        private System.Windows.Forms.Label labelBrowse;
        private System.Windows.Forms.Button buttonRefreshUSB;
        private System.Windows.Forms.GroupBox groupBoxUSB;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelInstructions2;
        private System.Windows.Forms.MenuStrip menuStripAbout;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    }
}


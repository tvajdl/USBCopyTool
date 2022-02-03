
namespace USBCopy_v2
{
    partial class FormWorking
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
            this.buttonWorkingCancel = new System.Windows.Forms.Button();
            this.labelWorking = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWorkingCancel
            // 
            this.buttonWorkingCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonWorkingCancel.Location = new System.Drawing.Point(29, 138);
            this.buttonWorkingCancel.Name = "buttonWorkingCancel";
            this.buttonWorkingCancel.Size = new System.Drawing.Size(93, 23);
            this.buttonWorkingCancel.TabIndex = 3;
            this.buttonWorkingCancel.Text = "Prekliči";
            // 
            // labelWorking
            // 
            this.labelWorking.Location = new System.Drawing.Point(35, 96);
            this.labelWorking.Name = "labelWorking";
            this.labelWorking.Size = new System.Drawing.Size(73, 13);
            this.labelWorking.TabIndex = 1;
            this.labelWorking.Text = "Formatiranje...";
            this.labelWorking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLoading.Image = global::USBCopyTool.Properties.Resources.Gray_circles_rotate;
            this.pictureBoxLoading.Location = new System.Drawing.Point(29, 7);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(93, 70);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoading.TabIndex = 2;
            this.pictureBoxLoading.TabStop = false;
            // 
            // FormWorking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 173);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxLoading);
            this.Controls.Add(this.buttonWorkingCancel);
            this.Controls.Add(this.labelWorking);
            this.Name = "FormWorking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWorkingCancel;
        private System.Windows.Forms.Label labelWorking;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
    }
}
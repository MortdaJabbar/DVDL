namespace DVDL.Applications.LocalLicense
{
    partial class frmShowLicenseInfo
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ctrDrivingLicenseInfo1 = new ctrDrivingLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LicenseView_400;
            pictureBox1.Location = new Point(114, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(260, 199);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 0;
            label2.Text = "License Info";
            // 
            // ctrDrivingLicenseInfo1
            // 
            ctrDrivingLicenseInfo1.Location = new Point(12, 234);
            ctrDrivingLicenseInfo1.Name = "ctrDrivingLicenseInfo1";
            ctrDrivingLicenseInfo1.Size = new Size(709, 328);
            ctrDrivingLicenseInfo1.TabIndex = 2;
            // 
            // frmShowLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 574);
            Controls.Add(ctrDrivingLicenseInfo1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "frmShowLicenseInfo";
            Text = "frmShowLicenseInfo";
            Load += frmShowLicenseInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private ctrDrivingLicenseInfo ctrDrivingLicenseInfo1;
    }
}
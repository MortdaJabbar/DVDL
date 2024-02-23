namespace DVDL
{
    partial class frmReleaseLicense
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
            ctrDrivingLicenseInfoWithFilter1 = new Applications.LocalLicense.ctrDrivingLicenseInfoWithFilter();
            lbTitle = new Label();
            gbDetainInfo = new GroupBox();
            lbApplicationID = new Label();
            pictureBox8 = new PictureBox();
            label10 = new Label();
            lbTotalFees = new Label();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            lbApplicationFees = new Label();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            lbCreatedByUser = new Label();
            lbLicenseID = new Label();
            lbFineFees = new Label();
            lbDetainDate = new Label();
            lbDetainID = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRelease = new Button();
            btnClose = new Button();
            llShowLicenseInfo = new LinkLabel();
            llShowPersonHistoryLicense = new LinkLabel();
            gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrDrivingLicenseInfoWithFilter1
            // 
            ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = true;
           
            ctrDrivingLicenseInfoWithFilter1.Location = new Point(12, 76);
            ctrDrivingLicenseInfoWithFilter1.Name = "ctrDrivingLicenseInfoWithFilter1";
            ctrDrivingLicenseInfoWithFilter1.Size = new Size(699, 424);
            ctrDrivingLicenseInfoWithFilter1.TabIndex = 0;
            ctrDrivingLicenseInfoWithFilter1.OnLicenseSelected += ctrDrivingLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16F);
            lbTitle.ForeColor = Color.DarkRed;
            lbTitle.Location = new Point(255, 26);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(162, 30);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Release License";
            // 
            // gbDetainInfo
            // 
            gbDetainInfo.Controls.Add(lbApplicationID);
            gbDetainInfo.Controls.Add(pictureBox8);
            gbDetainInfo.Controls.Add(label10);
            gbDetainInfo.Controls.Add(lbTotalFees);
            gbDetainInfo.Controls.Add(label8);
            gbDetainInfo.Controls.Add(pictureBox7);
            gbDetainInfo.Controls.Add(label9);
            gbDetainInfo.Controls.Add(lbApplicationFees);
            gbDetainInfo.Controls.Add(pictureBox4);
            gbDetainInfo.Controls.Add(label7);
            gbDetainInfo.Controls.Add(lbCreatedByUser);
            gbDetainInfo.Controls.Add(lbLicenseID);
            gbDetainInfo.Controls.Add(lbFineFees);
            gbDetainInfo.Controls.Add(lbDetainDate);
            gbDetainInfo.Controls.Add(lbDetainID);
            gbDetainInfo.Controls.Add(pictureBox5);
            gbDetainInfo.Controls.Add(pictureBox6);
            gbDetainInfo.Controls.Add(pictureBox3);
            gbDetainInfo.Controls.Add(pictureBox2);
            gbDetainInfo.Controls.Add(pictureBox1);
            gbDetainInfo.Controls.Add(label5);
            gbDetainInfo.Controls.Add(label4);
            gbDetainInfo.Controls.Add(label3);
            gbDetainInfo.Controls.Add(label2);
            gbDetainInfo.Controls.Add(label1);
            gbDetainInfo.Font = new Font("Segoe UI", 10F);
            gbDetainInfo.Location = new Point(12, 496);
            gbDetainInfo.Name = "gbDetainInfo";
            gbDetainInfo.Size = new Size(688, 148);
            gbDetainInfo.TabIndex = 2;
            gbDetainInfo.TabStop = false;
            gbDetainInfo.Text = "Detain Info";
            // 
            // lbApplicationID
            // 
            lbApplicationID.AutoSize = true;
            lbApplicationID.Location = new Point(498, 117);
            lbApplicationID.Name = "lbApplicationID";
            lbApplicationID.Size = new Size(35, 19);
            lbApplicationID.TabIndex = 24;
            lbApplicationID.Text = "[???]";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Number_32;
            pictureBox8.Location = new Point(459, 115);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(33, 21);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 23;
            pictureBox8.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(359, 115);
            label10.Name = "label10";
            label10.Size = new Size(94, 19);
            label10.TabIndex = 22;
            label10.Text = "ApplicationID:";
            // 
            // lbTotalFees
            // 
            lbTotalFees.AutoSize = true;
            lbTotalFees.Location = new Point(499, 84);
            lbTotalFees.Name = "lbTotalFees";
            lbTotalFees.Size = new Size(17, 19);
            lbTotalFees.TabIndex = 21;
            lbTotalFees.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 86);
            label8.Name = "label8";
            label8.Size = new Size(0, 19);
            label8.TabIndex = 20;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.money_32;
            pictureBox7.Location = new Point(459, 84);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 21);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(381, 84);
            label9.Name = "label9";
            label9.Size = new Size(72, 19);
            label9.TabIndex = 18;
            label9.Text = "Total Fees:";
            // 
            // lbApplicationFees
            // 
            lbApplicationFees.AutoSize = true;
            lbApplicationFees.Location = new Point(147, 117);
            lbApplicationFees.Name = "lbApplicationFees";
            lbApplicationFees.Size = new Size(17, 19);
            lbApplicationFees.TabIndex = 17;
            lbApplicationFees.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(116, 117);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 117);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 15;
            label7.Text = "Application Fees:";
            // 
            // lbCreatedByUser
            // 
            lbCreatedByUser.AutoSize = true;
            lbCreatedByUser.Location = new Point(490, 51);
            lbCreatedByUser.Name = "lbCreatedByUser";
            lbCreatedByUser.Size = new Size(35, 19);
            lbCreatedByUser.TabIndex = 14;
            lbCreatedByUser.Text = "[???]";
            // 
            // lbLicenseID
            // 
            lbLicenseID.AutoSize = true;
            lbLicenseID.Location = new Point(490, 21);
            lbLicenseID.Name = "lbLicenseID";
            lbLicenseID.Size = new Size(35, 19);
            lbLicenseID.TabIndex = 13;
            lbLicenseID.Text = "[???]";
            // 
            // lbFineFees
            // 
            lbFineFees.AutoSize = true;
            lbFineFees.Location = new Point(147, 86);
            lbFineFees.Name = "lbFineFees";
            lbFineFees.Size = new Size(17, 19);
            lbFineFees.TabIndex = 12;
            lbFineFees.Text = "0";
            // 
            // lbDetainDate
            // 
            lbDetainDate.AutoSize = true;
            lbDetainDate.Location = new Point(147, 51);
            lbDetainDate.Name = "lbDetainDate";
            lbDetainDate.Size = new Size(35, 19);
            lbDetainDate.TabIndex = 11;
            lbDetainDate.Text = "[???]";
            // 
            // lbDetainID
            // 
            lbDetainID.AutoSize = true;
            lbDetainID.Location = new Point(155, 24);
            lbDetainID.Name = "lbDetainID";
            lbDetainID.Size = new Size(35, 19);
            lbDetainID.TabIndex = 10;
            lbDetainID.Text = "[???]";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.User_32__2;
            pictureBox5.Location = new Point(459, 51);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Driver_License_48;
            pictureBox6.Location = new Point(459, 21);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(116, 86);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_321;
            pictureBox2.Location = new Point(116, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(116, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 51);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 4;
            label5.Text = "Created By:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 24);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 3;
            label4.Text = "LicenseID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 2;
            label3.Text = "Fine Fees:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 51);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "DetainDate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 26);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 0;
            label1.Text = "DetainID:";
            // 
            // btnRelease
            // 
            btnRelease.Enabled = false;
            btnRelease.FlatStyle = FlatStyle.Flat;
            btnRelease.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelease.Image = Properties.Resources.Release_Detained_License_32;
            btnRelease.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelease.Location = new Point(600, 650);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(86, 33);
            btnRelease.TabIndex = 3;
            btnRelease.Text = "Release";
            btnRelease.TextAlign = ContentAlignment.MiddleRight;
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(488, 650);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 33);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Enabled = false;
            llShowLicenseInfo.Font = new Font("Segoe UI", 12F);
            llShowLicenseInfo.LinkColor = Color.Black;
            llShowLicenseInfo.Location = new Point(255, 654);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(135, 21);
            llShowLicenseInfo.TabIndex = 5;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show Lincese Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // llShowPersonHistoryLicense
            // 
            llShowPersonHistoryLicense.AutoSize = true;
            llShowPersonHistoryLicense.Enabled = false;
            llShowPersonHistoryLicense.Font = new Font("Segoe UI", 12F);
            llShowPersonHistoryLicense.LinkColor = Color.Black;
            llShowPersonHistoryLicense.Location = new Point(18, 654);
            llShowPersonHistoryLicense.Name = "llShowPersonHistoryLicense";
            llShowPersonHistoryLicense.Size = new Size(209, 21);
            llShowPersonHistoryLicense.TabIndex = 6;
            llShowPersonHistoryLicense.TabStop = true;
            llShowPersonHistoryLicense.Text = "Show Person Histroy License";
            llShowPersonHistoryLicense.LinkClicked += llShowPersonHistoryLicense_LinkClicked;
            // 
            // frmReleaseLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 687);
            Controls.Add(llShowPersonHistoryLicense);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnClose);
            Controls.Add(btnRelease);
            Controls.Add(gbDetainInfo);
            Controls.Add(lbTitle);
            Controls.Add(ctrDrivingLicenseInfoWithFilter1);
            Name = "frmReleaseLicense";
            Text = "ReleaseLicense";
            Load += frmReleaseLicense_Load;
            gbDetainInfo.ResumeLayout(false);
            gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.LocalLicense.ctrDrivingLicenseInfoWithFilter ctrDrivingLicenseInfoWithFilter1;
        private Label lbTitle;
        private GroupBox gbDetainInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lbDetainID;
        private Label lbFineFees;
        private Label lbDetainDate;
        private Label lbCreatedByUser;
        private Label lbLicenseID;
        private Button btnRelease;
        private Button btnClose;
        private LinkLabel llShowLicenseInfo;
        private LinkLabel llShowPersonHistoryLicense;
        private Label lbApplicationFees;
        private PictureBox pictureBox4;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox7;
        private Label label9;
        private Label lbTotalFees;
        private Label lbApplicationID;
        private PictureBox pictureBox8;
        private Label label10;
    }
}

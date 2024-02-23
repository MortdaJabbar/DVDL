namespace DVDL
{
    partial class frmReplaceLicenseForDamgeOrLost
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
            gbReplaceFor = new GroupBox();
            rbReplaceLost = new RadioButton();
            rbDamagedLicense = new RadioButton();
            gbApplication = new GroupBox();
            lbCreatedByUser = new Label();
            lbLicenseID = new Label();
            lbReplacedLiceneseID = new Label();
            lbFees = new Label();
            lbApplicationDate = new Label();
            lbApplicationID = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnReplace = new Button();
            btnClose = new Button();
            ctrDrivingLicenseInfoWithFilter1 = new Applications.LocalLicense.ctrDrivingLicenseInfoWithFilter();
            llShowLicenseInfo = new LinkLabel();
            llShowPersonHistoryLicenes = new LinkLabel();
            lbTitle = new Label();
            gbReplaceFor.SuspendLayout();
            gbApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbReplaceFor
            // 
            gbReplaceFor.Controls.Add(rbReplaceLost);
            gbReplaceFor.Controls.Add(rbDamagedLicense);
            gbReplaceFor.Location = new Point(715, 88);
            gbReplaceFor.Name = "gbReplaceFor";
            gbReplaceFor.Size = new Size(259, 100);
            gbReplaceFor.TabIndex = 2;
            gbReplaceFor.TabStop = false;
            gbReplaceFor.Text = "ReplaceFor";
            // 
            // rbReplaceLost
            // 
            rbReplaceLost.AutoSize = true;
            rbReplaceLost.Font = new Font("Segoe UI", 12F);
            rbReplaceLost.Location = new Point(25, 63);
            rbReplaceLost.Name = "rbReplaceLost";
            rbReplaceLost.Size = new Size(112, 25);
            rbReplaceLost.TabIndex = 1;
            rbReplaceLost.Text = "Lost License";
            rbReplaceLost.UseVisualStyleBackColor = true;
            rbReplaceLost.CheckedChanged += rbReplaceLost_CheckedChanged;
            // 
            // rbDamagedLicense
            // 
            rbDamagedLicense.AutoSize = true;
            rbDamagedLicense.Checked = true;
            rbDamagedLicense.Font = new Font("Segoe UI", 12F);
            rbDamagedLicense.Location = new Point(25, 22);
            rbDamagedLicense.Name = "rbDamagedLicense";
            rbDamagedLicense.Size = new Size(150, 25);
            rbDamagedLicense.TabIndex = 0;
            rbDamagedLicense.TabStop = true;
            rbDamagedLicense.Text = "Damaged License";
            rbDamagedLicense.UseVisualStyleBackColor = true;
            rbDamagedLicense.CheckedChanged += rbDamagedLicense_CheckedChanged;
            // 
            // gbApplication
            // 
            gbApplication.Controls.Add(lbCreatedByUser);
            gbApplication.Controls.Add(lbLicenseID);
            gbApplication.Controls.Add(lbReplacedLiceneseID);
            gbApplication.Controls.Add(lbFees);
            gbApplication.Controls.Add(lbApplicationDate);
            gbApplication.Controls.Add(lbApplicationID);
            gbApplication.Controls.Add(pictureBox4);
            gbApplication.Controls.Add(pictureBox5);
            gbApplication.Controls.Add(pictureBox6);
            gbApplication.Controls.Add(label5);
            gbApplication.Controls.Add(label6);
            gbApplication.Controls.Add(label7);
            gbApplication.Controls.Add(pictureBox3);
            gbApplication.Controls.Add(pictureBox2);
            gbApplication.Controls.Add(pictureBox1);
            gbApplication.Controls.Add(label4);
            gbApplication.Controls.Add(label3);
            gbApplication.Controls.Add(label2);
            gbApplication.Font = new Font("Segoe UI", 10F);
            gbApplication.Location = new Point(12, 507);
            gbApplication.Name = "gbApplication";
            gbApplication.Size = new Size(697, 153);
            gbApplication.TabIndex = 5;
            gbApplication.TabStop = false;
            gbApplication.Text = "Application Basic Info";
            // 
            // lbCreatedByUser
            // 
            lbCreatedByUser.AutoSize = true;
            lbCreatedByUser.Location = new Point(531, 97);
            lbCreatedByUser.Name = "lbCreatedByUser";
            lbCreatedByUser.Size = new Size(35, 19);
            lbCreatedByUser.TabIndex = 17;
            lbCreatedByUser.Text = "[???]";
            // 
            // lbLicenseID
            // 
            lbLicenseID.AutoSize = true;
            lbLicenseID.Location = new Point(531, 65);
            lbLicenseID.Name = "lbLicenseID";
            lbLicenseID.Size = new Size(35, 19);
            lbLicenseID.TabIndex = 16;
            lbLicenseID.Text = "[???]";
            // 
            // lbReplacedLiceneseID
            // 
            lbReplacedLiceneseID.AutoSize = true;
            lbReplacedLiceneseID.Location = new Point(531, 36);
            lbReplacedLiceneseID.Name = "lbReplacedLiceneseID";
            lbReplacedLiceneseID.Size = new Size(35, 19);
            lbReplacedLiceneseID.TabIndex = 15;
            lbReplacedLiceneseID.Text = "[???]";
            // 
            // lbFees
            // 
            lbFees.AutoSize = true;
            lbFees.Location = new Point(166, 97);
            lbFees.Name = "lbFees";
            lbFees.Size = new Size(35, 19);
            lbFees.TabIndex = 14;
            lbFees.Text = "[???]";
            // 
            // lbApplicationDate
            // 
            lbApplicationDate.AutoSize = true;
            lbApplicationDate.Location = new Point(166, 65);
            lbApplicationDate.Name = "lbApplicationDate";
            lbApplicationDate.Size = new Size(35, 19);
            lbApplicationDate.TabIndex = 13;
            lbApplicationDate.Text = "[???]";
            // 
            // lbApplicationID
            // 
            lbApplicationID.AutoSize = true;
            lbApplicationID.Location = new Point(166, 36);
            lbApplicationID.Name = "lbApplicationID";
            lbApplicationID.Size = new Size(35, 19);
            lbApplicationID.TabIndex = 12;
            lbApplicationID.Text = "[???]";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.User_32__2;
            pictureBox4.Location = new Point(481, 97);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Driver_License_48;
            pictureBox5.Location = new Point(481, 65);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Driver_License_48;
            pictureBox6.Location = new Point(481, 36);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 97);
            label5.Name = "label5";
            label5.Size = new Size(103, 19);
            label5.TabIndex = 8;
            label5.Text = "CreatedByUser:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 65);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 7;
            label6.Text = "LicenseID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 36);
            label7.Name = "label7";
            label7.Size = new Size(128, 19);
            label7.TabIndex = 6;
            label7.Text = "Replaced LicenseID:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(125, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_32;
            pictureBox2.Location = new Point(125, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(125, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 97);
            label4.Name = "label4";
            label4.Size = new Size(111, 19);
            label4.TabIndex = 2;
            label4.Text = "Application Fees:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 65);
            label3.Name = "label3";
            label3.Size = new Size(113, 19);
            label3.TabIndex = 1;
            label3.Text = "Application Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 0;
            label2.Text = "Application ID:";
            // 
            // btnReplace
            // 
            btnReplace.Enabled = false;
            btnReplace.FlatStyle = FlatStyle.Flat;
            btnReplace.Font = new Font("Segoe UI", 12F);
            btnReplace.Image = Properties.Resources.Renew_Driving_License_32;
            btnReplace.ImageAlign = ContentAlignment.MiddleLeft;
            btnReplace.Location = new Point(595, 666);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(114, 38);
            btnReplace.TabIndex = 6;
            btnReplace.Text = "Replace";
            btnReplace.TextAlign = ContentAlignment.MiddleRight;
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(462, 666);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(102, 38);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctrDrivingLicenseInfoWithFilter1
            // 
            ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = true;
            ctrDrivingLicenseInfoWithFilter1.Location = new Point(0, 75);
            ctrDrivingLicenseInfoWithFilter1.Name = "ctrDrivingLicenseInfoWithFilter1";
            ctrDrivingLicenseInfoWithFilter1.Size = new Size(709, 409);
            ctrDrivingLicenseInfoWithFilter1.TabIndex = 8;
            ctrDrivingLicenseInfoWithFilter1.OnLicenseSelected += ctrDrivingLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Font = new Font("Segoe UI", 12F);
            llShowLicenseInfo.LinkColor = Color.Black;
            llShowLicenseInfo.Location = new Point(255, 683);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(135, 21);
            llShowLicenseInfo.TabIndex = 9;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show License Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // llShowPersonHistoryLicenes
            // 
            llShowPersonHistoryLicenes.AutoSize = true;
            llShowPersonHistoryLicenes.Font = new Font("Segoe UI", 12F);
            llShowPersonHistoryLicenes.LinkColor = Color.Black;
            llShowPersonHistoryLicenes.Location = new Point(18, 683);
            llShowPersonHistoryLicenes.Name = "llShowPersonHistoryLicenes";
            llShowPersonHistoryLicenes.Size = new Size(209, 21);
            llShowPersonHistoryLicenes.TabIndex = 10;
            llShowPersonHistoryLicenes.TabStop = true;
            llShowPersonHistoryLicenes.Text = "Show Person History Licenes";
            llShowPersonHistoryLicenes.LinkClicked += llShowPersonHistoryLicenes_LinkClicked;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.DarkRed;
            lbTitle.Location = new Point(270, 30);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(261, 25);
            lbTitle.TabIndex = 11;
            lbTitle.Text = "Replace  For Damged License";
            // 
            // frmReplaceLicenseForDamgeOrLost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 716);
            Controls.Add(lbTitle);
            Controls.Add(llShowPersonHistoryLicenes);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(ctrDrivingLicenseInfoWithFilter1);
            Controls.Add(btnClose);
            Controls.Add(btnReplace);
            Controls.Add(gbApplication);
            Controls.Add(gbReplaceFor);
            Name = "frmReplaceLicenseForDamgeOrLost";
            Text = "frmReplaceLicenseForDamgeOrLost";
            Load += frmReplaceLicenseForDamgeOrLost_Load;
            gbReplaceFor.ResumeLayout(false);
            gbReplaceFor.PerformLayout();
            gbApplication.ResumeLayout(false);
            gbApplication.PerformLayout();
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
        private GroupBox gbReplaceFor;
        private RadioButton rbReplaceLost;
        private RadioButton rbDamagedLicense;
        private GroupBox gbApplication;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbFees;
        private Label lbApplicationDate;
        private Label lbApplicationID;
        private Label lbCreatedByUser;
        private Label lbLicenseID;
        private Label lbReplacedLiceneseID;
        private Button btnReplace;
        private Button btnClose;
        private Applications.LocalLicense.ctrDrivingLicenseInfoWithFilter ctrDrivingLicenseInfoWithFilter1;
        private LinkLabel llShowLicenseInfo;
        private LinkLabel llShowPersonHistoryLicenes;
        private Label lbTitle;
    }
}
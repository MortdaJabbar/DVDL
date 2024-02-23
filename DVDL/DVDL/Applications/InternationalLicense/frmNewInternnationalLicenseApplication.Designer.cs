namespace DVDL.Applications.InternationalLicense
{
    partial class frmNewInternnationalLicenseApplication
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
            ctrDrivingLicenseInfoWithFilter1 = new LocalLicense.ctrDrivingLicenseInfoWithFilter();
            lbTitle = new Label();
            gbApplication = new GroupBox();
            lbCreatedByUserID = new Label();
            lbExpirationDate = new Label();
            lbLocalLicenseID = new Label();
            lbILLicneseID = new Label();
            lbFees = new Label();
            lbIssueDate = new Label();
            lbApplicationDate = new Label();
            lbILApplicationID = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnIssue = new Button();
            btnClose = new Button();
            llShowLicenseInfo = new LinkLabel();
            llShowLicneseHistory = new LinkLabel();
            gbApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrDrivingLicenseInfoWithFilter1
            // 
            ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = true;
            ctrDrivingLicenseInfoWithFilter1.Location = new Point(-1, 57);
            ctrDrivingLicenseInfoWithFilter1.Name = "ctrDrivingLicenseInfoWithFilter1";
            ctrDrivingLicenseInfoWithFilter1.Size = new Size(717, 413);
            ctrDrivingLicenseInfoWithFilter1.TabIndex = 0;
            ctrDrivingLicenseInfoWithFilter1.OnLicenseSelected += ctrDrivingLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Maroon;
            lbTitle.Location = new Point(154, 24);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(324, 30);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "International License Application";
            // 
            // gbApplication
            // 
            gbApplication.Controls.Add(lbCreatedByUserID);
            gbApplication.Controls.Add(lbExpirationDate);
            gbApplication.Controls.Add(lbLocalLicenseID);
            gbApplication.Controls.Add(lbILLicneseID);
            gbApplication.Controls.Add(lbFees);
            gbApplication.Controls.Add(lbIssueDate);
            gbApplication.Controls.Add(lbApplicationDate);
            gbApplication.Controls.Add(lbILApplicationID);
            gbApplication.Controls.Add(pictureBox5);
            gbApplication.Controls.Add(pictureBox6);
            gbApplication.Controls.Add(pictureBox7);
            gbApplication.Controls.Add(pictureBox8);
            gbApplication.Controls.Add(label5);
            gbApplication.Controls.Add(label6);
            gbApplication.Controls.Add(label7);
            gbApplication.Controls.Add(label8);
            gbApplication.Controls.Add(pictureBox4);
            gbApplication.Controls.Add(pictureBox3);
            gbApplication.Controls.Add(pictureBox2);
            gbApplication.Controls.Add(pictureBox1);
            gbApplication.Controls.Add(label4);
            gbApplication.Controls.Add(label3);
            gbApplication.Controls.Add(label2);
            gbApplication.Controls.Add(label1);
            gbApplication.Font = new Font("Segoe UI", 10F);
            gbApplication.Location = new Point(12, 476);
            gbApplication.Name = "gbApplication";
            gbApplication.Size = new Size(694, 151);
            gbApplication.TabIndex = 2;
            gbApplication.TabStop = false;
            gbApplication.Text = "Application info";
            // 
            // lbCreatedByUserID
            // 
            lbCreatedByUserID.AutoSize = true;
            lbCreatedByUserID.Location = new Point(571, 121);
            lbCreatedByUserID.Name = "lbCreatedByUserID";
            lbCreatedByUserID.Size = new Size(35, 19);
            lbCreatedByUserID.TabIndex = 22;
            lbCreatedByUserID.Text = "[???]";
            // 
            // lbExpirationDate
            // 
            lbExpirationDate.AutoSize = true;
            lbExpirationDate.Location = new Point(571, 94);
            lbExpirationDate.Name = "lbExpirationDate";
            lbExpirationDate.Size = new Size(35, 19);
            lbExpirationDate.TabIndex = 21;
            lbExpirationDate.Text = "[???]";
            // 
            // lbLocalLicenseID
            // 
            lbLocalLicenseID.AutoSize = true;
            lbLocalLicenseID.Location = new Point(571, 63);
            lbLocalLicenseID.Name = "lbLocalLicenseID";
            lbLocalLicenseID.Size = new Size(35, 19);
            lbLocalLicenseID.TabIndex = 20;
            lbLocalLicenseID.Text = "[???]";
            // 
            // lbILLicneseID
            // 
            lbILLicneseID.AutoSize = true;
            lbILLicneseID.Location = new Point(571, 32);
            lbILLicneseID.Name = "lbILLicneseID";
            lbILLicneseID.Size = new Size(35, 19);
            lbILLicneseID.TabIndex = 19;
            lbILLicneseID.Text = "[???]";
            // 
            // lbFees
            // 
            lbFees.AutoSize = true;
            lbFees.Location = new Point(149, 125);
            lbFees.Name = "lbFees";
            lbFees.Size = new Size(35, 19);
            lbFees.TabIndex = 18;
            lbFees.Text = "[???]";
            // 
            // lbIssueDate
            // 
            lbIssueDate.AutoSize = true;
            lbIssueDate.Location = new Point(149, 93);
            lbIssueDate.Name = "lbIssueDate";
            lbIssueDate.Size = new Size(35, 19);
            lbIssueDate.TabIndex = 17;
            lbIssueDate.Text = "[???]";
            // 
            // lbApplicationDate
            // 
            lbApplicationDate.AutoSize = true;
            lbApplicationDate.Location = new Point(149, 62);
            lbApplicationDate.Name = "lbApplicationDate";
            lbApplicationDate.Size = new Size(35, 19);
            lbApplicationDate.TabIndex = 16;
            lbApplicationDate.Text = "[???]";
            // 
            // lbILApplicationID
            // 
            lbILApplicationID.AutoSize = true;
            lbILApplicationID.Location = new Point(149, 31);
            lbILApplicationID.Name = "lbILApplicationID";
            lbILApplicationID.Size = new Size(35, 19);
            lbILApplicationID.TabIndex = 3;
            lbILApplicationID.Text = "[???]";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.money_32;
            pictureBox5.Location = new Point(545, 119);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Calendar_32;
            pictureBox6.Location = new Point(545, 91);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Calendar_32;
            pictureBox7.Location = new Point(545, 62);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(20, 20);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Number_32;
            pictureBox8.Location = new Point(545, 31);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(20, 20);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 121);
            label5.Name = "label5";
            label5.Size = new Size(117, 19);
            label5.TabIndex = 11;
            label5.Text = "CreatedByUserID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(426, 93);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 10;
            label6.Text = "Expiration Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(426, 62);
            label7.Name = "label7";
            label7.Size = new Size(105, 19);
            label7.TabIndex = 9;
            label7.Text = "Local LicenseID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 31);
            label8.Name = "label8";
            label8.Size = new Size(87, 19);
            label8.TabIndex = 8;
            label8.Text = "I.L.LicenseID:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(125, 125);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Calendar_32;
            pictureBox3.Location = new Point(123, 92);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_32;
            pictureBox2.Location = new Point(125, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(123, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 120);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 3;
            label4.Text = "Fees:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 2;
            label3.Text = "Issue Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(113, 19);
            label2.TabIndex = 1;
            label2.Text = "Application Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 0;
            label1.Text = "I.L.ApplicationID:";
            // 
            // btnIssue
            // 
            btnIssue.Enabled = false;
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Segoe UI", 12F);
            btnIssue.Image = Properties.Resources.International_32;
            btnIssue.ImageAlign = ContentAlignment.MiddleLeft;
            btnIssue.Location = new Point(615, 636);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(91, 34);
            btnIssue.TabIndex = 3;
            btnIssue.Text = "Issue";
            btnIssue.TextAlign = ContentAlignment.MiddleRight;
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(506, 636);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 34);
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
            llShowLicenseInfo.Font = new Font("Segoe UI", 11F);
            llShowLicenseInfo.LinkColor = Color.Black;
            llShowLicenseInfo.Location = new Point(191, 653);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(127, 20);
            llShowLicenseInfo.TabIndex = 5;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show License Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // llShowLicneseHistory
            // 
            llShowLicneseHistory.AutoSize = true;
            llShowLicneseHistory.Font = new Font("Segoe UI", 11F);
            llShowLicneseHistory.LinkColor = Color.Black;
            llShowLicneseHistory.Location = new Point(18, 653);
            llShowLicneseHistory.Name = "llShowLicneseHistory";
            llShowLicneseHistory.Size = new Size(154, 20);
            llShowLicneseHistory.TabIndex = 6;
            llShowLicneseHistory.TabStop = true;
            llShowLicneseHistory.Text = "Show Licenses History";
            llShowLicneseHistory.LinkClicked += llShowLicneseHistory_LinkClicked;
            // 
            // frmNewInternnationalLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 682);
            Controls.Add(llShowLicneseHistory);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(gbApplication);
            Controls.Add(lbTitle);
            Controls.Add(ctrDrivingLicenseInfoWithFilter1);
            Name = "frmNewInternnationalLicenseApplication";
            Text = "frmNewInternnationalLicenseApplication";
            gbApplication.ResumeLayout(false);
            gbApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LocalLicense.ctrDrivingLicenseInfoWithFilter ctrDrivingLicenseInfoWithFilter1;
        private Label lbTitle;
        private GroupBox gbApplication;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbILApplicationID;
        private Label lbApplicationDate;
        private Label lbIssueDate;
        private Label lbFees;
        private Label lbCreatedByUserID;
        private Label lbExpirationDate;
        private Label lbLocalLicenseID;
        private Label lbILLicneseID;
        private Button btnIssue;
        private Button btnClose;
        private LinkLabel llShowLicenseInfo;
        private LinkLabel llShowLicneseHistory;
    }
}
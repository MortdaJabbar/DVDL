namespace DVDL
{
    partial class frmRenewLocalDrivingLicense
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
            gbApplication = new GroupBox();
            txtNotes = new TextBox();
            pictureBox11 = new PictureBox();
            label12 = new Label();
            lbTotalFees = new Label();
            pictureBox10 = new PictureBox();
            label11 = new Label();
            lbApplicationFees = new Label();
            pictureBox9 = new PictureBox();
            label10 = new Label();
            lbCreatedByUserID = new Label();
            lbExpirationDate = new Label();
            lbOldLicenseID = new Label();
            lbLicenseID = new Label();
            lbClassFees = new Label();
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
            btnRenew = new Button();
            btnClose = new Button();
            llShowLicenseInfo = new LinkLabel();
            llShowLicneseHistory = new LinkLabel();
            gbApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
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
            ctrDrivingLicenseInfoWithFilter1.Location = new Point(2, 42);
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
            lbTitle.Location = new Point(181, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(264, 30);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Renew License Application";
            // 
            // gbApplication
            // 
            gbApplication.Controls.Add(txtNotes);
            gbApplication.Controls.Add(pictureBox11);
            gbApplication.Controls.Add(label12);
            gbApplication.Controls.Add(lbTotalFees);
            gbApplication.Controls.Add(pictureBox10);
            gbApplication.Controls.Add(label11);
            gbApplication.Controls.Add(lbApplicationFees);
            gbApplication.Controls.Add(pictureBox9);
            gbApplication.Controls.Add(label10);
            gbApplication.Controls.Add(lbCreatedByUserID);
            gbApplication.Controls.Add(lbExpirationDate);
            gbApplication.Controls.Add(lbOldLicenseID);
            gbApplication.Controls.Add(lbLicenseID);
            gbApplication.Controls.Add(lbClassFees);
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
            gbApplication.Location = new Point(12, 461);
            gbApplication.Name = "gbApplication";
            gbApplication.Size = new Size(694, 221);
            gbApplication.TabIndex = 2;
            gbApplication.TabStop = false;
            gbApplication.Text = "Application info";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(467, 145);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(221, 70);
            txtNotes.TabIndex = 31;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.Notes_32;
            pictureBox11.Location = new Point(441, 150);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(20, 20);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 30;
            pictureBox11.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(385, 151);
            label12.Name = "label12";
            label12.Size = new Size(48, 19);
            label12.TabIndex = 29;
            label12.Text = "Notes:";
            // 
            // lbTotalFees
            // 
            lbTotalFees.AutoSize = true;
            lbTotalFees.Location = new Point(151, 198);
            lbTotalFees.Name = "lbTotalFees";
            lbTotalFees.Size = new Size(35, 19);
            lbTotalFees.TabIndex = 28;
            lbTotalFees.Text = "[???]";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.money_32;
            pictureBox10.Location = new Point(127, 198);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(20, 20);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 27;
            pictureBox10.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 199);
            label11.Name = "label11";
            label11.Size = new Size(72, 19);
            label11.TabIndex = 26;
            label11.Text = "Total Fees:";
            // 
            // lbApplicationFees
            // 
            lbApplicationFees.AutoSize = true;
            lbApplicationFees.Location = new Point(151, 163);
            lbApplicationFees.Name = "lbApplicationFees";
            lbApplicationFees.Size = new Size(35, 19);
            lbApplicationFees.TabIndex = 25;
            lbApplicationFees.Text = "[???]";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.money_32;
            pictureBox9.Location = new Point(127, 163);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(20, 20);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 24;
            pictureBox9.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 164);
            label10.Name = "label10";
            label10.Size = new Size(111, 19);
            label10.TabIndex = 23;
            label10.Text = "Application Fees:";
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
            // lbOldLicenseID
            // 
            lbOldLicenseID.AutoSize = true;
            lbOldLicenseID.Location = new Point(571, 63);
            lbOldLicenseID.Name = "lbOldLicenseID";
            lbOldLicenseID.Size = new Size(35, 19);
            lbOldLicenseID.TabIndex = 20;
            lbOldLicenseID.Text = "[???]";
            // 
            // lbLicenseID
            // 
            lbLicenseID.AutoSize = true;
            lbLicenseID.Location = new Point(571, 32);
            lbLicenseID.Name = "lbLicenseID";
            lbLicenseID.Size = new Size(35, 19);
            lbLicenseID.TabIndex = 19;
            lbLicenseID.Text = "[???]";
            // 
            // lbClassFees
            // 
            lbClassFees.AutoSize = true;
            lbClassFees.Location = new Point(149, 125);
            lbClassFees.Name = "lbClassFees";
            lbClassFees.Size = new Size(35, 19);
            lbClassFees.TabIndex = 18;
            lbClassFees.Text = "[???]";
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
            pictureBox5.Image = Properties.Resources.User_32__2;
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
            pictureBox7.Image = Properties.Resources.Driver_License_48;
            pictureBox7.Location = new Point(545, 62);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(20, 20);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Driver_License_48;
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
            label7.Size = new Size(96, 19);
            label7.TabIndex = 9;
            label7.Text = "Old LicenseID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 31);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 8;
            label8.Text = "LicenseID:";
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
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 3;
            label4.Text = "Class Fees:";
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
            // btnRenew
            // 
            btnRenew.Enabled = false;
            btnRenew.FlatStyle = FlatStyle.Flat;
            btnRenew.Font = new Font("Segoe UI", 12F);
            btnRenew.Image = Properties.Resources.Renew_Driving_License_32;
            btnRenew.ImageAlign = ContentAlignment.MiddleLeft;
            btnRenew.Location = new Point(597, 687);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(103, 34);
            btnRenew.TabIndex = 3;
            btnRenew.Text = "Renew";
            btnRenew.TextAlign = ContentAlignment.MiddleRight;
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(500, 687);
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
            llShowLicenseInfo.Location = new Point(185, 704);
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
            llShowLicneseHistory.Location = new Point(12, 704);
            llShowLicneseHistory.Name = "llShowLicneseHistory";
            llShowLicneseHistory.Size = new Size(154, 20);
            llShowLicneseHistory.TabIndex = 6;
            llShowLicneseHistory.TabStop = true;
            llShowLicneseHistory.Text = "Show Licenses History";
            llShowLicneseHistory.LinkClicked += llShowLicneseHistory_LinkClicked;
            // 
            // frmRenewLocalDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(780, 749);
            Controls.Add(llShowLicneseHistory);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnClose);
            Controls.Add(btnRenew);
            Controls.Add(gbApplication);
            Controls.Add(lbTitle);
            Controls.Add(ctrDrivingLicenseInfoWithFilter1);
            Name = "frmRenewLocalDrivingLicense";
            Text = "Renew License";
            Load += frmRenewLocalDrivingLicense_Load_1;
            gbApplication.ResumeLayout(false);
            gbApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
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

        private Applications.LocalLicense.ctrDrivingLicenseInfoWithFilter ctrDrivingLicenseInfoWithFilter1;
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
        private Label lbClassFees;
        private Label lbCreatedByUserID;
        private Label lbExpirationDate;
        private Label lbOldLicenseID;
        private Label lbLicenseID;
        private Button btnRenew;
        private Button btnClose;
        private LinkLabel llShowLicenseInfo;
        private LinkLabel llShowLicneseHistory;
        private Label lbApplicationFees;
        private PictureBox pictureBox9;
        private Label label10;
        private Label lbTotalFees;
        private PictureBox pictureBox10;
        private Label label11;
        private PictureBox pictureBox11;
        private Label label12;
        private TextBox txtNotes;
    }
}
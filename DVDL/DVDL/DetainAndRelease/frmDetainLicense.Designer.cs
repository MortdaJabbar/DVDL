namespace DVDL.DetainAndRelease
{
    partial class frmDetainLicense
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
            components = new System.ComponentModel.Container();
            ctrDrivingLicenseInfoWithFilter1 = new Applications.LocalLicense.ctrDrivingLicenseInfoWithFilter();
            lbTitle = new Label();
            gbDetainInfo = new GroupBox();
            txtFineFees = new TextBox();
            lbCreatedByUser = new Label();
            lbLicenseID = new Label();
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
            btnDetain = new Button();
            btnClose = new Button();
            llShowLicenseInfo = new LinkLabel();
            llShowPersonHistoryLicense = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrDrivingLicenseInfoWithFilter1
            // 
            ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = true;
            ctrDrivingLicenseInfoWithFilter1.Location = new Point(1, 59);
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
            lbTitle.Size = new Size(151, 30);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Detain License";
            // 
            // gbDetainInfo
            // 
            gbDetainInfo.Controls.Add(txtFineFees);
            gbDetainInfo.Controls.Add(lbCreatedByUser);
            gbDetainInfo.Controls.Add(lbLicenseID);
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
            // txtFineFees
            // 
            txtFineFees.Location = new Point(147, 72);
            txtFineFees.Name = "txtFineFees";
            txtFineFees.Size = new Size(44, 25);
            txtFineFees.TabIndex = 15;
            txtFineFees.CausesValidation = true;
            txtFineFees.KeyPress += txtFineFees_KeyPress;
            txtFineFees.Validating += txtFineFees_Validating;
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
            // lbDetainDate
            // 
            lbDetainDate.AutoSize = true;
            lbDetainDate.Location = new Point(147, 46);
            lbDetainDate.Name = "lbDetainDate";
            lbDetainDate.Size = new Size(35, 19);
            lbDetainDate.TabIndex = 11;
            lbDetainDate.Text = "[???]";
            // 
            // lbDetainID
            // 
            lbDetainID.AutoSize = true;
            lbDetainID.Location = new Point(147, 19);
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
            pictureBox3.Location = new Point(116, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_321;
            pictureBox2.Location = new Point(116, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(116, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 21);
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
            label4.Location = new Point(374, 21);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 3;
            label4.Text = "LicenseID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 75);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 2;
            label3.Text = "Fine Fees:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "DetainDate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 0;
            label1.Text = "DetainID:";
            // 
            // btnDetain
            // 
            btnDetain.Enabled = false;
            btnDetain.FlatStyle = FlatStyle.Flat;
            btnDetain.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetain.Image = Properties.Resources.Detain_32;
            btnDetain.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetain.Location = new Point(600, 650);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(86, 33);
            btnDetain.TabIndex = 3;
            btnDetain.Text = "Detain";
            btnDetain.TextAlign = ContentAlignment.MiddleRight;
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 687);
            Controls.Add(llShowPersonHistoryLicense);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnClose);
            Controls.Add(btnDetain);
            Controls.Add(gbDetainInfo);
            Controls.Add(lbTitle);
            Controls.Add(ctrDrivingLicenseInfoWithFilter1);
            Name = "frmDetainLicense";
            Text = "frmDetainLicense";
            Load += frmDetainLicense_Load;
            gbDetainInfo.ResumeLayout(false);
            gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private Label lbDetainDate;
        private Label lbCreatedByUser;
        private Label lbLicenseID;
        private Button btnDetain;
        private Button btnClose;
        private LinkLabel llShowLicenseInfo;
        private LinkLabel llShowPersonHistoryLicense;
        private TextBox txtFineFees;
        private ErrorProvider errorProvider1;
    }
}
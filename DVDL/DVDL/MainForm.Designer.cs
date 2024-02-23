namespace DVDL
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            msApplication = new ToolStripMenuItem();
            drivingLicensesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            newLocalDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            newInternaionalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            replaceLicenseForLostOrDamagedToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationToolStripMenuItem = new ToolStripMenuItem();
            mangeLocalDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageInternaionalLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageDetainLicenseToolStripMenuItem = new ToolStripMenuItem();
            tsmiDetainLicense = new ToolStripMenuItem();
            tsmiReleaseLicense = new ToolStripMenuItem();
            tsmiManageDetainLicense = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypeToolStripMenuItem = new ToolStripMenuItem();
            tsmPeople = new ToolStripMenuItem();
            tsmDrivers = new ToolStripMenuItem();
            tsmUsers = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            tsmCurrentUserInfo = new ToolStripMenuItem();
            tsmChangePassword = new ToolStripMenuItem();
            tsmSignOut = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { msApplication, tsmPeople, tsmDrivers, tsmUsers, toolStripMenuItem4 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(935, 72);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // msApplication
            // 
            msApplication.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesToolStripMenuItem, manageApplicationToolStripMenuItem, manageDetainLicenseToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageTestTypeToolStripMenuItem });
            msApplication.Font = new Font("Segoe UI", 12F);
            msApplication.Image = Properties.Resources.Applications_64;
            msApplication.ImageAlign = ContentAlignment.MiddleLeft;
            msApplication.ImageScaling = ToolStripItemImageScaling.None;
            msApplication.Name = "msApplication";
            msApplication.Padding = new Padding(2, 0, 2, 0);
            msApplication.Size = new Size(160, 68);
            msApplication.Text = "Application";
            // 
            // drivingLicensesToolStripMenuItem
            // 
            drivingLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, replaceLicenseForLostOrDamagedToolStripMenuItem });
            drivingLicensesToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            drivingLicensesToolStripMenuItem.Image = Properties.Resources.LocalDriving_License;
            drivingLicensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            drivingLicensesToolStripMenuItem.Name = "drivingLicensesToolStripMenuItem";
            drivingLicensesToolStripMenuItem.Size = new Size(278, 38);
            drivingLicensesToolStripMenuItem.Text = "Driving Licenses";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newLocalDrivingLicenseToolStripMenuItem, newInternaionalLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            newDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Driver_License_48;
            newDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(364, 54);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // newLocalDrivingLicenseToolStripMenuItem
            // 
            newLocalDrivingLicenseToolStripMenuItem.Image = Properties.Resources.New_Driving_License_32;
            newLocalDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newLocalDrivingLicenseToolStripMenuItem.Name = "newLocalDrivingLicenseToolStripMenuItem";
            newLocalDrivingLicenseToolStripMenuItem.Size = new Size(278, 38);
            newLocalDrivingLicenseToolStripMenuItem.Text = "New Local Driving License";
            newLocalDrivingLicenseToolStripMenuItem.Click += newLocalDrivingLicenseToolStripMenuItem_Click;
            // 
            // newInternaionalLicenseToolStripMenuItem
            // 
            newInternaionalLicenseToolStripMenuItem.Image = Properties.Resources.International_32;
            newInternaionalLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newInternaionalLicenseToolStripMenuItem.Name = "newInternaionalLicenseToolStripMenuItem";
            newInternaionalLicenseToolStripMenuItem.Size = new Size(278, 38);
            newInternaionalLicenseToolStripMenuItem.Text = "New Internaional License ";
            newInternaionalLicenseToolStripMenuItem.Click += newInternaionalLicenseToolStripMenuItem_Click;
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            renewDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Renew_Driving_License_32;
            renewDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(364, 54);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            renewDrivingLicenseToolStripMenuItem.Click += renewDrivingLicenseToolStripMenuItem_Click;
            // 
            // replaceLicenseForLostOrDamagedToolStripMenuItem
            // 
            replaceLicenseForLostOrDamagedToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            replaceLicenseForLostOrDamagedToolStripMenuItem.Image = Properties.Resources.Lost_Driving_License_32;
            replaceLicenseForLostOrDamagedToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            replaceLicenseForLostOrDamagedToolStripMenuItem.Name = "replaceLicenseForLostOrDamagedToolStripMenuItem";
            replaceLicenseForLostOrDamagedToolStripMenuItem.Size = new Size(364, 54);
            replaceLicenseForLostOrDamagedToolStripMenuItem.Text = "Replace License For Lost Or Damaged";
            replaceLicenseForLostOrDamagedToolStripMenuItem.Click += replaceLicenseForLostOrDamagedToolStripMenuItem_Click;
            // 
            // manageApplicationToolStripMenuItem
            // 
            manageApplicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mangeLocalDrivingLicenseToolStripMenuItem, manageInternaionalLicenseToolStripMenuItem });
            manageApplicationToolStripMenuItem.Image = Properties.Resources.Manage_Applications_32;
            manageApplicationToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            manageApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationToolStripMenuItem.Name = "manageApplicationToolStripMenuItem";
            manageApplicationToolStripMenuItem.Size = new Size(278, 38);
            manageApplicationToolStripMenuItem.Text = "Manage Application";
            // 
            // mangeLocalDrivingLicenseToolStripMenuItem
            // 
            mangeLocalDrivingLicenseToolStripMenuItem.Image = Properties.Resources.LocalDriving_License;
            mangeLocalDrivingLicenseToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            mangeLocalDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            mangeLocalDrivingLicenseToolStripMenuItem.Name = "mangeLocalDrivingLicenseToolStripMenuItem";
            mangeLocalDrivingLicenseToolStripMenuItem.Size = new Size(294, 38);
            mangeLocalDrivingLicenseToolStripMenuItem.Text = "MangeLocalDrivingLicense";
            mangeLocalDrivingLicenseToolStripMenuItem.Click += mangeLocalDrivingLicenseToolStripMenuItem_Click;
            // 
            // manageInternaionalLicenseToolStripMenuItem
            // 
            manageInternaionalLicenseToolStripMenuItem.Image = Properties.Resources.International_32;
            manageInternaionalLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageInternaionalLicenseToolStripMenuItem.Name = "manageInternaionalLicenseToolStripMenuItem";
            manageInternaionalLicenseToolStripMenuItem.Size = new Size(294, 38);
            manageInternaionalLicenseToolStripMenuItem.Text = "Manage Internaional License";
            manageInternaionalLicenseToolStripMenuItem.Click += manageInternaionalLicenseToolStripMenuItem_Click;
            // 
            // manageDetainLicenseToolStripMenuItem
            // 
            manageDetainLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiDetainLicense, tsmiReleaseLicense, tsmiManageDetainLicense });
            manageDetainLicenseToolStripMenuItem.Image = Properties.Resources.Detain_32;
            manageDetainLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageDetainLicenseToolStripMenuItem.Name = "manageDetainLicenseToolStripMenuItem";
            manageDetainLicenseToolStripMenuItem.Size = new Size(278, 38);
            manageDetainLicenseToolStripMenuItem.Text = " Detain License";
            // 
            // tsmiDetainLicense
            // 
            tsmiDetainLicense.Font = new Font("Segoe UI", 12F);
            tsmiDetainLicense.Image = Properties.Resources.Detain_32;
            tsmiDetainLicense.ImageAlign = ContentAlignment.MiddleLeft;
            tsmiDetainLicense.ImageScaling = ToolStripItemImageScaling.None;
            tsmiDetainLicense.Name = "tsmiDetainLicense";
            tsmiDetainLicense.Size = new Size(257, 38);
            tsmiDetainLicense.Text = "Detain License";
            tsmiDetainLicense.Click += tsmiDetainLicense_Click;
            // 
            // tsmiReleaseLicense
            // 
            tsmiReleaseLicense.Image = Properties.Resources.Release_Detained_License_32;
            tsmiReleaseLicense.ImageScaling = ToolStripItemImageScaling.None;
            tsmiReleaseLicense.Name = "tsmiReleaseLicense";
            tsmiReleaseLicense.Size = new Size(257, 38);
            tsmiReleaseLicense.Text = "Release License";
            tsmiReleaseLicense.Click += tsmiReleaseLicense_Click;
            // 
            // tsmiManageDetainLicense
            // 
            tsmiManageDetainLicense.Image = Properties.Resources.Detain_32;
            tsmiManageDetainLicense.ImageScaling = ToolStripItemImageScaling.None;
            tsmiManageDetainLicense.Name = "tsmiManageDetainLicense";
            tsmiManageDetainLicense.Size = new Size(257, 38);
            tsmiManageDetainLicense.Text = "Manage Detain License";
            tsmiManageDetainLicense.Click += tsmiManageDetainLicense_Click;
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            manageApplicationTypesToolStripMenuItem.Image = Properties.Resources.ApplicationType1;
            manageApplicationTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(278, 38);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypeToolStripMenuItem
            // 
            manageTestTypeToolStripMenuItem.Image = Properties.Resources.Schedule_Test_32;
            manageTestTypeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageTestTypeToolStripMenuItem.Name = "manageTestTypeToolStripMenuItem";
            manageTestTypeToolStripMenuItem.Size = new Size(278, 38);
            manageTestTypeToolStripMenuItem.Text = "Manage Test Type";
            manageTestTypeToolStripMenuItem.Click += manageTestTypeToolStripMenuItem_Click;
            // 
            // tsmPeople
            // 
            tsmPeople.Font = new Font("Segoe UI", 12F);
            tsmPeople.Image = Properties.Resources.People_64;
            tsmPeople.ImageAlign = ContentAlignment.MiddleLeft;
            tsmPeople.ImageScaling = ToolStripItemImageScaling.None;
            tsmPeople.Name = "tsmPeople";
            tsmPeople.Padding = new Padding(2, 0, 2, 0);
            tsmPeople.Size = new Size(128, 68);
            tsmPeople.Text = "People";
            tsmPeople.Click += tsmPeople_Click;
            // 
            // tsmDrivers
            // 
            tsmDrivers.Font = new Font("Segoe UI", 12F);
            tsmDrivers.Image = Properties.Resources.Drivers_64;
            tsmDrivers.ImageAlign = ContentAlignment.MiddleLeft;
            tsmDrivers.ImageScaling = ToolStripItemImageScaling.None;
            tsmDrivers.Name = "tsmDrivers";
            tsmDrivers.Padding = new Padding(2, 0, 2, 0);
            tsmDrivers.Size = new Size(132, 68);
            tsmDrivers.Text = "Drivers";
            tsmDrivers.Click += tsmDrivers_Click;
            // 
            // tsmUsers
            // 
            tsmUsers.Font = new Font("Segoe UI", 12F);
            tsmUsers.Image = Properties.Resources.Add_New_User_72;
            tsmUsers.ImageAlign = ContentAlignment.MiddleLeft;
            tsmUsers.ImageScaling = ToolStripItemImageScaling.None;
            tsmUsers.Name = "tsmUsers";
            tsmUsers.Padding = new Padding(2, 0, 2, 0);
            tsmUsers.Size = new Size(121, 68);
            tsmUsers.Text = "Users";
            tsmUsers.Click += tsmUsers_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { tsmCurrentUserInfo, tsmChangePassword, tsmSignOut });
            toolStripMenuItem4.Font = new Font("Segoe UI", 12F);
            toolStripMenuItem4.Image = Properties.Resources.account_settings_64;
            toolStripMenuItem4.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Padding = new Padding(2, 0, 2, 0);
            toolStripMenuItem4.Size = new Size(198, 68);
            toolStripMenuItem4.Text = "Account Settings";
            // 
            // tsmCurrentUserInfo
            // 
            tsmCurrentUserInfo.Image = Properties.Resources.PersonDetails_32;
            tsmCurrentUserInfo.ImageAlign = ContentAlignment.MiddleLeft;
            tsmCurrentUserInfo.ImageScaling = ToolStripItemImageScaling.None;
            tsmCurrentUserInfo.Name = "tsmCurrentUserInfo";
            tsmCurrentUserInfo.Size = new Size(219, 38);
            tsmCurrentUserInfo.Text = "Current User Info";
            tsmCurrentUserInfo.Click += tsmCurrentUserInfo_Click;
            // 
            // tsmChangePassword
            // 
            tsmChangePassword.Image = Properties.Resources.Password_32;
            tsmChangePassword.ImageAlign = ContentAlignment.MiddleLeft;
            tsmChangePassword.ImageScaling = ToolStripItemImageScaling.None;
            tsmChangePassword.Name = "tsmChangePassword";
            tsmChangePassword.Size = new Size(219, 38);
            tsmChangePassword.Text = "Change Password";
            tsmChangePassword.Click += tsmChangePassword_Click;
            // 
            // tsmSignOut
            // 
            tsmSignOut.Image = Properties.Resources.sign_out_32__2;
            tsmSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            tsmSignOut.ImageScaling = ToolStripItemImageScaling.None;
            tsmSignOut.Name = "tsmSignOut";
            tsmSignOut.Size = new Size(219, 38);
            tsmSignOut.Text = "Sign Out";
            tsmSignOut.Click += tsmSignOut_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 376);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.wallpaper;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(935, 376);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DVDL";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem msApplication;
        private ToolStripMenuItem tsmPeople;
        private ToolStripMenuItem tsmUsers;
        private ToolStripMenuItem tsmDrivers;
        private ToolStripMenuItem toolStripMenuItem4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem tsmCurrentUserInfo;
        private ToolStripMenuItem tsmChangePassword;
        private ToolStripMenuItem tsmSignOut;
        private ToolStripMenuItem drivingLicensesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationToolStripMenuItem;
        private ToolStripMenuItem mangeLocalDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem newLocalDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem newInternaionalLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem manageDetainLicenseToolStripMenuItem;
        private ToolStripMenuItem replaceLicenseForLostOrDamagedToolStripMenuItem;
        private ToolStripMenuItem manageInternaionalLicenseToolStripMenuItem;
        private ToolStripMenuItem tsmiDetainLicense;
        private ToolStripMenuItem tsmiReleaseLicense;
        private ToolStripMenuItem tsmiManageDetainLicense;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypeToolStripMenuItem;
    }
}

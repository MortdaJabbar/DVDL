using DVDL.Applications;
using DVDL.Applications.InternationalLicense;
using DVDL.Applications.LocalLicense;
using DVDL.DetainAndRelease;
using DVDL.Drivers;
using DVDL.Tests;
using DVDL.Users;
using DVDLBussinesLogicTier;

namespace DVDL
{
    public partial class MainForm : Form
    {
        frmLoginUser _frmLogin = null;
        public MainForm(frmLoginUser frmlogin)
        {
            InitializeComponent();
            _frmLogin = frmlogin;
        }

        private void tsmCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frmUser = new frmShowUserInfo(Global.CurrentUser.UserID);
            frmUser.ShowDialog();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChange = new frmChangePassword(Global.CurrentUser.UserID);
            frmChange.ShowDialog();
        }

        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            Global.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _frmLogin.Show();
        }

        private void tsmPeople_Click(object sender, EventArgs e)
        {
            Pepole.frmManagePepole managePeople = new Pepole.frmManagePepole();
            managePeople.ShowDialog();
        }

        private void tsmUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers manageuser = new frmManageUsers();
            manageuser.ShowDialog();

        }



        private void mangeLocalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMangeLocalDrivingLicensesApplication frm = new frmMangeLocalDrivingLicensesApplication();
            frm.ShowDialog();

        }

        private void tsmDrivers_Click(object sender, EventArgs e)
        {
            frmManageDrivers frm = new frmManageDrivers();
            frm.ShowDialog();
        }

        private void newLocalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicense frmLocalDrivingLicense = new frmAddUpdateLocalDrivingLicense();
            frmLocalDrivingLicense.ShowDialog();
        }

        private void newInternaionalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternnationalLicenseApplication frm = new frmNewInternnationalLicenseApplication();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense frm = new frmRenewLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void replaceLicenseForLostOrDamagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLicenseForDamgeOrLost frm = new frmReplaceLicenseForDamgeOrLost();
            frm.ShowDialog();
        }

        private void manageInternaionalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicense frm = new frmManageInternationalLicense();
            frm.ShowDialog();
        }

        private void tsmiDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void tsmiReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense();
            frm.ShowDialog();
        }

        private void tsmiManageDetainLicense_Click(object sender, EventArgs e)
        {
            frmManageDetainAndReleaseLicense frm = new frmManageDetainAndReleaseLicense();
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMangeTests frm = new frmMangeTests();
            frm.ShowDialog();
        }
    }
}

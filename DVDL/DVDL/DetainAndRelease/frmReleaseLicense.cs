using DVDL.Applications.LocalLicense;
using DVDL.Users;
using DVDLBussinesLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL
{
    public partial class frmReleaseLicense : Form
    {
        private clsLicense _License;

        private int _ApplicationID = -1;
       
        public frmReleaseLicense()
        {
            InitializeComponent();
        }
        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();
            ctrDrivingLicenseInfoWithFilter1.FillLicenesInfo(LicenseID);
            ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
         
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ctrDrivingLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int LicenseID = obj;
            _License = clsLicense.GetLicenseByID(LicenseID);
            _License = ctrDrivingLicenseInfoWithFilter1.License;
            if (!_License.IsActive)
            {
                gbDetainInfo.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                llShowPersonHistoryLicense.Enabled = true;
                ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
                btnRelease.Enabled = false;
                MessageBox.Show("Selected License  is not Active");

                return;
            }
            if (!_License.IsDetained)
            {
                gbDetainInfo.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                llShowPersonHistoryLicense.Enabled = true;
                ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
                btnRelease.Enabled = false;
                MessageBox.Show("Selected License  is not Detain");

                return;
            }
          
            lbDetainID.Text = _License.DetainedLicense.DetainID.ToString();
            lbApplicationFees.Text = clsApplicationType.FindApplicationTypeByID((int)clsApplicationType.enApplicationTypeID.ReleaseDetainLicense).Fees.ToString();
            lbCreatedByUser.Text = _License.CreatedByUserID.ToString();
            lbDetainDate.Text = _License.DetainedLicense.DetainDate.ToShortDateString();
            lbLicenseID.Text = _License.LicenseID.ToString();
            lbTotalFees.Text = (Convert.ToDecimal(lbApplicationFees.Text) + _License.DetainedLicense.FineFees).ToString();
            lbFineFees.Text = _License.DetainedLicense.FineFees.ToString();
            btnRelease.Enabled = true;
            llShowPersonHistoryLicense.Enabled = true;


        }
        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            Global.CurrentUser = clsUser.FindUserByUserID(1);
            llShowLicenseInfo.Enabled = false;
            llShowPersonHistoryLicense.Enabled = false;
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_License.LicenseID);
            frm.ShowDialog();
        }
        private void llShowPersonHistoryLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(_License.SelectedDriver.PersonID);
            frm.ShowDialog();
        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (_License.ReleaseLicense(Global.CurrentUser.UserID, ref _ApplicationID))
            {
                MessageBox.Show("\nLicense Release Successfully\n");
                llShowLicenseInfo.Enabled = true;
                llShowPersonHistoryLicense.Enabled = true;
                btnRelease.Enabled = false;
                ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
                lbApplicationID.Text = _ApplicationID.ToString();
               

            }
            else MessageBox.Show("Failed to Release");
            


        }
    
    
    }
}

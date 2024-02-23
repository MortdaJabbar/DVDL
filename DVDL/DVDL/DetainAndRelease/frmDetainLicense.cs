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

namespace DVDL.DetainAndRelease
{
    public partial class frmDetainLicense : Form
    {
        private clsLicense _License;
       
       
        public frmDetainLicense()
        {
            InitializeComponent();
        }
        public frmDetainLicense(int LicenseID)
        {
            InitializeComponent();
            ctrDrivingLicenseInfoWithFilter1.FillLicenesInfo(LicenseID);
          
            ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
        }
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            Global.CurrentUser = clsUser.FindUserByUserID(1);
        }
        private void ctrDrivingLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            int LicenseID = obj;
            _License = clsLicense.GetLicenseByID(LicenseID);


            llShowPersonHistoryLicense.Enabled = true;
            if (!_License.IsActive)
            {
                gbDetainInfo.Enabled = false;

                MessageBox.Show("Selected License is not Active ");
                llShowLicenseInfo.Enabled = true;
                return;
            }
            if (_License.IsDetained)
            {
                gbDetainInfo.Enabled = false;

                MessageBox.Show("Selected License is Already Detained");
                llShowLicenseInfo.Enabled = true;
                return;
            }
            gbDetainInfo.Enabled = true;
            llShowLicenseInfo.Enabled = false;
            lbLicenseID.Text = LicenseID.ToString();
            lbDetainDate.Text = DateTime.Now.ToShortDateString();
            lbCreatedByUser.Text = Global.CurrentUser.UserName;
          
            btnDetain.Enabled = true;


        }
        private void llShowPersonHistoryLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = _License.SelectedDriver.PersonID;
            frmShowLicenseHistory frm = new frmShowLicenseHistory(PersonID);
            frm.ShowDialog();
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_License.LicenseID);
            frm.ShowDialog();
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) { return; }

            Decimal FineFees = Decimal.Parse(txtFineFees.Text);

            if (_License.DetainLicense(FineFees, Global.CurrentUser.UserID) != -1)
            {
                lbDetainID.Text = _License.DetainedLicense.DetainID.ToString();
                btnDetain.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                MessageBox.Show("License Detained Successfuly");
                ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
            }
            else { MessageBox.Show("Error With Detain License"); }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (txtFineFees.Text.Trim() == "") { e.Cancel = true; errorProvider1.SetError(txtFineFees, "Fine Ammount Required"); }  
            else if ((Convert.ToDecimal(txtFineFees.Text) ) < 0) 
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Please Enter A Fine Ammount ");
            }
            else errorProvider1.SetError(txtFineFees, null);
        }
    }
}

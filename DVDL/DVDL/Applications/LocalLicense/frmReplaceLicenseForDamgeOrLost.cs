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
    public partial class frmReplaceLicenseForDamgeOrLost : Form
    {
        int _LicenseID = -1;
        int _PersonID = -1;
        private clsLicense _License;
        private clsLicense _NewLicense;
        private clsApplication _Application;
        private int _ApplicationTypeID = 4;
        public bool ReplaceOptionEnable { get { return gbReplaceFor.Enabled; } set { gbReplaceFor.Enabled = value; } }

        public frmReplaceLicenseForDamgeOrLost()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!_Application.Save()) { MessageBox.Show("Error With Application"); return; }
            _NewLicense.ApplicationID = _Application.ApplicationID;
            if (!_NewLicense.Save()) { MessageBox.Show("Error With New License"); return; }
            else MessageBox.Show($"License Replaced With New License By ID {_NewLicense.LicenseID} Successfuly");
            _Application.ApplicationStatus = 3;
            _Application.LastStatusDate = DateTime.Now;
            _Application.Save();
            _License.IsActive = false;
            _License.Save();
            lbReplacedLiceneseID.Text = _NewLicense.LicenseID.ToString();
            lbApplicationID.Text = _NewLicense.ApplicationID.ToString();
            btnReplace.Enabled = false;
            llShowLicenseInfo.Enabled = true;
            _LicenseID = _NewLicense.LicenseID;
            _PersonID = _NewLicense.SelectedDriver.PersonID;
            ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
        }
        private void InitalApplicationAndFillInfo()
        {

            _Application = new clsApplication();
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationPersonID = _License.SelectedApplication.ApplicationPersonID;
            _Application.CreatedByUserID = _License.CreatedByUserID;
            _Application.ApplicationTypeID = _ApplicationTypeID;
            _Application.ApplicationStatus = 1;
            _Application.LastStatusDate = DateTime.Now;
            lbApplicationDate.Text = _Application.ApplicationDate.ToShortDateString();
            lbFees.Text = clsApplicationType.FindApplicationTypeByID(_ApplicationTypeID).Fees.ToString();
            _Application.PaiedFees = Convert.ToDecimal(lbFees.Text);
            lbCreatedByUser.Text = clsUser.FindUserByUserID(_License.CreatedByUserID).UserName;
        }
        private void InitalNewLicenseAndFillInfo()
        {
            _NewLicense = new clsLicense();
            _NewLicense.CreatedByUserID = Global.CurrentUser.UserID;
            _NewLicense.DriverID = _License.DriverID;
            _NewLicense.Notes = _License.Notes;
            _NewLicense.PaiedFees = 0;
            _NewLicense.IsActive = true;
            _NewLicense.IssueReason = (byte)_ApplicationTypeID;
            _NewLicense.IssueDate = DateTime.Now;
            _NewLicense.ExpirationDate = _License.ExpirationDate;
            _NewLicense.LicenseClassID = _License.LicenseClassID;
            lbLicenseID.Text = _License.LicenseID.ToString();


        }
        private void ctrDrivingLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _License = clsLicense.GetLicenseByID(_LicenseID);
            _PersonID = _License.SelectedDriver.PersonID;
          
            if (!_License.IsActive)
            {
                gbApplication.Enabled = false;
                btnReplace.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                llShowPersonHistoryLicenes.Enabled = true;

                MessageBox.Show("This License is  not Active You Can't Replace it");
                return;
            }
            ReplaceOptionEnable = true;
            btnReplace.Enabled = true;
            gbApplication.Enabled = true;
            InitalApplicationAndFillInfo();
            InitalNewLicenseAndFillInfo();

        }
        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked)
            {
                _ApplicationTypeID = 4;
                _Application.ApplicationTypeID = _ApplicationTypeID;
                lbFees.Text = clsApplicationType.FindApplicationTypeByID(_ApplicationTypeID).Fees.ToString();
                _Application.PaiedFees = Convert.ToDecimal(lbFees.Text);
                lbTitle.Text = "Replace For Damaged License";
                _NewLicense.IssueReason = (byte)_ApplicationTypeID;
            }
        }
        private void rbReplaceLost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReplaceLost.Checked)
            {
                _ApplicationTypeID = 3;
                _Application.ApplicationTypeID = _ApplicationTypeID;
                lbFees.Text = clsApplicationType.FindApplicationTypeByID(_ApplicationTypeID).Fees.ToString();
                _Application.PaiedFees = Convert.ToDecimal(lbFees.Text);
                lbTitle.Text = "Replace For Lost License";
                _NewLicense.IssueReason = (byte)_ApplicationTypeID;
            }
        }
        private void frmReplaceLicenseForDamgeOrLost_Load(object sender, EventArgs e)
        {
            Global.CurrentUser = clsUser.FindUserByUserID(1);
            ReplaceOptionEnable = false;
            llShowLicenseInfo.Enabled = false;

        }

        private void llShowPersonHistoryLicenes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(_License.SelectedDriver.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LicenseID);
            frm.ShowDialog();

        }
    }
}

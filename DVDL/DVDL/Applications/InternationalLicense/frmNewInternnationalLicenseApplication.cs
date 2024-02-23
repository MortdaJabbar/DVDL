using DVDL.InternationalLicense;
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

namespace DVDL.Applications.InternationalLicense
{
    public partial class frmNewInternnationalLicenseApplication : Form
    {
        private clsLicense _License;

        private clsInternationalLicense _InternationalLicense;

        private int _ApplicationTypeIDForInterNationalLicense = 6;

        private clsApplication _Application;
        public frmNewInternnationalLicenseApplication()
        {
            InitializeComponent();
            btnIssue.Enabled = false;
        }
        private bool _CanIssueInternationalLicense(clsLicense License)
        {
            if (!License.IsActive || DateTime.Compare(DateTime.Now, License.ExpirationDate) > 0)
            {
                return false;
            }
            return true;
        }
        private void InitalApplicationAndFillInfo()
        {
            _Application = new clsApplication();
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = _ApplicationTypeIDForInterNationalLicense;
            _Application.ApplicationPersonID = _License.SelectedApplication.ApplicationPersonID;
            _Application.CreatedByUserID = _License.CreatedByUserID;
            _Application.ApplicationStatus = 1;
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaiedFees = Convert.ToDecimal(lbFees.Text);
            lbApplicationDate.Text = _Application.ApplicationDate.ToShortDateString();
            lbFees.Text = clsApplicationType.FindApplicationTypeByID(_ApplicationTypeIDForInterNationalLicense).Fees.ToString();
            lbCreatedByUserID.Text = clsUser.FindUserByUserID(_License.CreatedByUserID).UserName;
        }
        private void InitalInterNationalLicenseAndFillInfo()
        {
            _InternationalLicense = new clsInternationalLicense();

            _InternationalLicense.CreatedByUserID = _License.CreatedByUserID;
            _InternationalLicense.DriverID = _License.DriverID;
            _InternationalLicense.IsActive = true;
            _InternationalLicense.LocalLicenseID = _License.LicenseID;
            _InternationalLicense.IssueDate = DateTime.Now;
            _InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            lbExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
            lbIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lbILLicneseID.Text = "[???]";

        }
        private void _FillInitalInfo()
        {
            _License = ctrDrivingLicenseInfoWithFilter1.License;
            lbLocalLicenseID.Text = _License.LicenseID.ToString();
            lbFees.Text = clsApplicationType.FindApplicationTypeByID(_ApplicationTypeIDForInterNationalLicense).Fees.ToString();
            InitalApplicationAndFillInfo();
            InitalInterNationalLicenseAndFillInfo();
            btnIssue.Enabled = _CanIssueInternationalLicense(_License);

        }
        private void _FillInterntaionlLicenseInfo()
        {
            _License = ctrDrivingLicenseInfoWithFilter1.License;
            lbLocalLicenseID.Text = _License.LicenseID.ToString();
            lbFees.Text = clsApplicationType.FindApplicationTypeByID(_ApplicationTypeIDForInterNationalLicense).Fees.ToString();
            lbApplicationDate.Text = _InternationalLicense.Application.ApplicationDate.ToShortDateString();
            lbCreatedByUserID.Text = _InternationalLicense.User.UserName;
            lbExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
            lbILLicneseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lbILApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lbIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lbTitle.Text = "International License Info";
            btnIssue.Enabled = false;
            llShowLicenseInfo.Enabled = true;
            ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
        }
        private void ctrDrivingLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int LocalLicenseID = obj;
            _InternationalLicense = clsInternationalLicense.FindInernationalLicenseByLocalLicenseID(LocalLicenseID);
            if (_InternationalLicense != null)
            {
                _FillInterntaionlLicenseInfo();
            }
            else _FillInitalInfo();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (!_Application.Save()) { MessageBox.Show("Application Failed"); return; }
            _InternationalLicense.ApplicationID = _Application.ApplicationID;
            if (!_InternationalLicense.Save()) { MessageBox.Show("International Licnese Failed"); return; }
            MessageBox.Show($"International License Has Beend Issued Successfuly With ID {_InternationalLicense.InternationalLicenseID}");
            _Application.ApplicationStatus = 3;
            _Application.LastStatusDate = DateTime.Now;
            _Application.Save();
            lbILApplicationID.Text = _Application.ApplicationID.ToString();
            lbILLicneseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            btnIssue.Enabled = false;
            llShowLicenseInfo.Enabled = true;
            ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicense frm = new frmShowInternationalLicense(_InternationalLicense.InternationalLicenseID);
            frm.ShowDialog();
        }
        private void llShowLicneseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(_License.SelectedDriver.PersonID);
            frm.ShowDialog();
        }
    }
}

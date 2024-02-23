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
    public partial class frmRenewLocalDrivingLicense : Form
    {
        
        private int _LicenseID = -1;
        
        private clsLicense _License;
        
        private clsLicense _NewLicense;
        
        private clsApplication _Application;
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }
       
        private void InitalApplicationAndLicenseInfo() 
        {
            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            lbApplicationFees.Text = clsApplicationType.FindApplicationTypeByID((int)clsApplicationType.enApplicationTypeID.RenewLicense).Fees.ToString();
            lbCreatedByUserID.Text = Global.CurrentUser.UserName;
            lbClassFees.Text = _License.SelectedLicenseClass.ClassFees.ToString();
            lbTotalFees.Text = (clsApplicationType.FindApplicationTypeByID((int)clsApplicationType.enApplicationTypeID.RenewLicense).Fees + _License.SelectedLicenseClass.ClassFees).ToString();
            lbIssueDate.Text = DateTime.Now.ToShortDateString();
            lbExpirationDate.Text =(DateTime.Now.AddYears(_License.SelectedLicenseClass.DefaultValidityLength)).ToShortDateString();
            lbOldLicenseID.Text = _LicenseID.ToString();
        }
        private bool IsLiceneseRenewed()
        {
            if (_License.IsLicenseRenewd())
            {
                
                gbApplication.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                llShowLicneseHistory.Enabled = true;
                btnRenew.Enabled = false;
                return true;
            }
            
                gbApplication.Enabled = true;
                llShowLicenseInfo.Enabled = false;
                llShowLicneseHistory.Enabled = false;
                btnRenew.Enabled = true;
            
            return false;
        }
        private bool IsLicenseNotExpired() 
        {
            if (!_License.IsLicneseExpired())
            {
                gbApplication.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                llShowLicneseHistory.Enabled = true;
                btnRenew.Enabled = false;
                return true;

            }

            gbApplication.Enabled = true;
            llShowLicenseInfo.Enabled = false;
            llShowLicneseHistory.Enabled = false;
            btnRenew.Enabled = true;
            return false;
        }
        private void ctrDrivingLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _License = clsLicense.GetLicenseByID(_LicenseID);
            if(!_License.IsActive) { MessageBox.Show($"The Selected Licesnse is not active"); return; }
            if (IsLiceneseRenewed()) { MessageBox.Show($"The Selected Licesnse Has Been Renewed With License ID {_License.RenewedLicenseID}"); return; }
            if (IsLicenseNotExpired()) { MessageBox.Show($"The Selected Licesnse Has Not Expired yet (still active)"); return; }
            InitalApplicationAndLicenseInfo();
            btnRenew.Enabled = true;
          
       
        }
        private void frmRenewLocalDrivingLicense_Load_1(object sender, EventArgs e)
        {
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {

            _NewLicense = _License.RenewLicense("Some Thing", Global.CurrentUser.UserID);
            if (_NewLicense!=null) 
            {
                MessageBox.Show($"License Renewed Successfuly With License ID {_NewLicense.LicenseID}");
                lbLicenseID.Text = _NewLicense.LicenseID.ToString();
                lbILApplicationID.Text = _NewLicense.ApplicationID.ToString();
                btnRenew.Enabled = false;
                llShowLicenseInfo.Enabled = false;
                llShowLicneseHistory.Enabled = false;
                ctrDrivingLicenseInfoWithFilter1.gbFilterEnable = false;
            }else
            {
                MessageBox.Show($"License Renewed Failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }
        private void llShowLicneseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            frmShowLicenseHistory frm = new frmShowLicenseHistory(_License.SelectedDriver.PersonID);
            frm.ShowDialog();
        }
    }
}

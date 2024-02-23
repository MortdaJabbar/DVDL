using DVDL.Pepole;
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

namespace DVDL.Applications.LocalLicense
{
    public partial class ctrLocalDrivingLicenseCard : UserControl
    {
        private int _LDLAppID = -1;
        private clsLocalDrivingLicense _LocalDrivingLicense;
        public ctrLocalDrivingLicenseCard()
        {
            InitializeComponent();
        }
        public ctrLocalDrivingLicenseCard(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            lkShowLicenseInfo.Enabled = false;
        }

        public int LocalDrivingLicenseID { get { return _LDLAppID; } set { _LDLAppID = value; } }
        public bool ShowLicnesInfo { get { return lkShowLicenseInfo.Enabled; } set { lkShowLicenseInfo.Enabled = value; } }
        public clsLocalDrivingLicense localDrivingLicense { get { return _LocalDrivingLicense; } }
        public void LoadLocalDrivingLicenseInfo(int LDLAppID)
        {
            _LocalDrivingLicense = clsLocalDrivingLicense.FindLocalDrivingLicense(LDLAppID);
            if (localDrivingLicense != null)
            {
                lbApplicant.Text = localDrivingLicense.Application.ApplicationPersonID.ToString();
                lbApplicationID.Text = localDrivingLicense.ApplicationID.ToString();
                lbAppliedForLicense.Text = localDrivingLicense.LicenseCLass.ClassName;
                lbDate.Text = localDrivingLicense.Application.ApplicationDate.ToShortDateString();
                lbFees.Text = localDrivingLicense.Application.PaiedFees.ToString();
                lbLDLAppID.Text = localDrivingLicense.LocalDrivingLicenseID.ToString();
                lbStatus.Text = localDrivingLicense.Application.StatusText;
                lbStatusDate.Text = localDrivingLicense.Application.LastStatusDate.ToShortDateString();
                lbUser.Text = localDrivingLicense.Application.CreatedByUserID.ToString();
                lbType.Text = localDrivingLicense.Application.SelectedApplicationType.ApplicationTypeTitle;
                lbPassedTest.Text = localDrivingLicense.GetNumberOfPassedTests().ToString() + "/3";
                lkShowLicenseInfo.Enabled = (localDrivingLicense.Application.ApplicationStatus == 3);
            }
            else _ResetInfo();

        }
        public void RefershPassedTest() { lbPassedTest.Text = localDrivingLicense.GetNumberOfPassedTests().ToString() + "/3"; }
        private void _ResetInfo()
        {

            lbApplicant.Text = "[???]";
            lbApplicationID.Text = "[???]";
            lbAppliedForLicense.Text = "[???]";
            lbDate.Text = "[???]";
            lbFees.Text = "[???]";
            lbLDLAppID.Text = "[???]";
            lbStatus.Text = "[???]";
            lbStatusDate.Text = "[???]";
            lbUser.Text = "[???]";
            lbType.Text = "[???]";
            lbPassedTest.Text = "[???]";
            _LocalDrivingLicense = null;
        }
        private void ctrLocalDrivingLicenseCard_Load(object sender, EventArgs e)
        {
            if (_LDLAppID != -1)
            {
                LoadLocalDrivingLicenseInfo(_LDLAppID);
            }
            else _ResetInfo();
        }
        private void lkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(localDrivingLicense.Application.ApplicationPersonID);
            frm.ShowDialog();
        }
        private void lkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int LicenseID = clsLicense.GetLicenseIDByApplication(localDrivingLicense.LicenseClassID, localDrivingLicense.ApplicationID);
            
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }
    }
}

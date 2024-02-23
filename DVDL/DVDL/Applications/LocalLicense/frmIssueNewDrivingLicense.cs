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

namespace DVDL.Applications.LocalLicense
{
    public partial class frmIssueNewDrivingLicense : Form
    {
        public delegate void IssueNewDrivingLicenseEventHandler(object Sender, int LicenseID);
        public event   IssueNewDrivingLicenseEventHandler DataBack;
        private int _LDLApp = -1;
        private clsLocalDrivingLicense _localDrivingLicenseApplication;
        public frmIssueNewDrivingLicense(int LDLapp)
        {
            InitializeComponent();
            _LDLApp = LDLapp;
        }

        private void frmIssueNewDrivingLicense_Load(object sender, EventArgs e)
        {
            _localDrivingLicenseApplication = clsLocalDrivingLicense.FindLocalDrivingLicense(_LDLApp);
            if (_localDrivingLicenseApplication == null) {
                MessageBox.Show($"Sorry, There is No Local Driving License Application With ID {_LDLApp} ");
                return;
            }
            if (!_localDrivingLicenseApplication.PassedAllTest()) 
            {
                MessageBox.Show("Person Does Not Passed All Tests , So You Can't Issue A License");
                return;
            }
            
            int LicenseID = _localDrivingLicenseApplication.GetActiveLicenseIDForLicenseClass();
            
            if (LicenseID != -1)
            {
                MessageBox.Show($"This Person Already Have License For This License Class With License ID {LicenseID}");
                return;
            }

            ctrLocalDrivingLicenseCard1.LoadLocalDrivingLicenseInfo(_LDLApp);
           

        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            int LicenseID = _localDrivingLicenseApplication.IssueLicenseForFirstTime("First License", Global.CurrentUser.UserID);


            if (LicenseID!=-1)
            {
                MessageBox.Show($"License Added Successfuly With LicenseID {LicenseID} ","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                _localDrivingLicenseApplication.Application.ApplicationStatus = 3;
                _localDrivingLicenseApplication.Application.Save();
                DataBack?.Invoke(this,LicenseID);
                btnIssue.Enabled = false;
                ctrLocalDrivingLicenseCard1.ShowLicnesInfo = true;
                this.Close();
            }
            else MessageBox.Show("Error ouccers ", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

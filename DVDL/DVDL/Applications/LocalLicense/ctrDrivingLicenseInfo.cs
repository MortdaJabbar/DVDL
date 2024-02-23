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
using DVDLBussinesLogicTier;
namespace DVDL.Applications.LocalLicense
{
    public partial class ctrDrivingLicenseInfo : UserControl
    {
        private int _LicenseID = -1;

        private clsLicense _license;
        public clsLicense License { get { return _license; } }
        public ctrDrivingLicenseInfo()
        {
            InitializeComponent();
           
        }
        public ctrDrivingLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        public void FillLicenseInfo(int LicenseID)
        {
            _license = clsLicense.GetLicenseByID(LicenseID);
            if (_license != null)
            {
                lbClass.Text = _license.SelectedLicenseClass.ClassName;
                lbDateOfBirth.Text = _license.SelectedApplication.SelectedPerson.BirthDate.ToShortDateString();
                lbDriverID.Text = _license.DriverID.ToString();
                lbExpairationDate.Text = _license.ExpirationDate.ToShortDateString();
                lbGender.Text = _license.SelectedApplication.SelectedPerson.GenderText;
                lbIsActive.Text = _license.IsActiveText;
                lbIssueDate.Text = _license.IssueDate.ToShortDateString();
                lbIssueReason.Text = _license.IssueReasonText;
                lbLicenseID.Text = _license.LicenseID.ToString();
                lbName.Text = _license.SelectedApplication.SelectedPerson.FullName;
                lbNationalNo.Text = _license.SelectedApplication.SelectedPerson.NationalNumber;
                lbNotes.Text = _license.Notes;
                pbPersonImage.ImageLocation = _license.SelectedApplication.SelectedPerson.ImagePath;
                if (clsLicense.IsLicenseDetained(LicenseID)) { lbIsDetained.Text = "Yes"; }
                else lbIsDetained.Text = "No";

            }
        }
        private void ctrDrivingLicenseInfo_Load(object sender, EventArgs e)
        {
            FillLicenseInfo(_LicenseID);
        }
    }
}

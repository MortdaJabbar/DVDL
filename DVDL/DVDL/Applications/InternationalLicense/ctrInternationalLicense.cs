using System;
using DVDLBussinesLogicTier;
using Microsoft.VisualBasic;

namespace DVDL.InternationalLicense
{

    public partial class ctrInternationalLicense : UserControl
    {
        public clsInternationalLicense InternationalLicense;

        private int _InternatioanlLicenseID = -1;
        
        public ctrInternationalLicense()
        {
            InitializeComponent();

        }
        public ctrInternationalLicense(int InternatioanlLicenseID)
        {
            InitializeComponent();
            _InternatioanlLicenseID = InternatioanlLicenseID;
        }

        public void FillLicenseInfo(int InternationalLicenseID)
        {
            InternationalLicense = clsInternationalLicense.FindInternationalNumber(InternationalLicenseID);
            lbApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            lbBirthDate.Text = InternationalLicense.Application.SelectedPerson.BirthDate.ToShortDateString();
            lbDriverID.Text = InternationalLicense.DriverID.ToString();
            lbExpirationDate.Text = InternationalLicense.ExpirationDate.ToShortDateString();
            lbIssueDate.Text = InternationalLicense.IssueDate.ToShortDateString();
            lbName.Text = InternationalLicense.Application.SelectedPerson.FullName;
            lbNationalNo.Text = InternationalLicense.Application.SelectedPerson.NationalNumber;
            pbPersonImage.ImageLocation = InternationalLicense.Application.SelectedPerson.ImagePath;
            lbGender.Text = InternationalLicense.Application.SelectedPerson.GenderText;
            lbBirthDate.Text = InternationalLicense.Application.SelectedPerson.BirthDate.ToShortDateString();
            lbIsActive.Text = InternationalLicense.Application.SelectedPerson.GenderText;
            lbILicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
        }

        private void ctrInternationalLicense_Load(object sender, EventArgs e)
        {
            
            if (clsInternationalLicense.IsInternationalLicenseExsist(_InternatioanlLicenseID)) 
            {
                FillLicenseInfo(_InternatioanlLicenseID);
            }
            
        }
    }
}

using DVDLAccessDataTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVDLBussinesLogicTier
{
    public class clsLicense
    {
        public enum enMode {Add=1,Update=2 }
        public enum enIssueReason {FirstTime = 1 , Renew = 2 ,LostReplacement = 3 ,DamagedReplacement=4  }
        private enMode _Mode;
        private clsApplication _Application { get; set; }
        public clsApplication SelectedApplication { get { return _Application; } }
        private clsLicenseClass _LicenseClass { get; set; }
        public clsLicenseClass SelectedLicenseClass { get { return _LicenseClass; } }
        private clsDriver _Driver { get; set; }
        private  int _DetainedID { get; set; }
        public clsDetainLicense DetainedLicense { get; set; }
        public clsDriver SelectedDriver { get { return _Driver; } }
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID {get; set;}
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public Decimal PaiedFees { get; set; }
        public bool  IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public int RenewedLicenseID { get; set; }
        public int ReplacedLicenseID { get; set; }
        public bool IsDetained { get { return clsLicense.IsLicenseDetained(this.LicenseID); } }
        public string IsActiveText { get{ return (IsActive == false) ? "No" : "Yes"; } }
        public string IssueReasonText 
        { 
            get 
            {
                switch (IssueReason) 
                {
                    case 1: return "First Time";
                    case 2: return "Renew";
                    case 3: return "Replacement for Lost";
                    case 4: return "Replacement for Damaged";
                }
                return "Unknown";
            } 
        }
        public clsLicense() 
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaiedFees = 0;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;
            this.RenewedLicenseID = -1;
            this.ReplacedLicenseID = -1;
            _Mode = enMode.Add;
            _Driver = new clsDriver();
            _Application = new clsApplication();
            _LicenseClass = new clsLicenseClass();
     
        }
        public clsLicense(int licenseID, int applicationID, int DriverID, int licenseClassID, DateTime issueDate, DateTime expirationDate, string notes, Decimal paiedFees, bool isActive, byte issueReason, int createdByUserID)
        {
           this.LicenseID = licenseID;
           this.ApplicationID = applicationID;
           this.DriverID = DriverID;
           this.LicenseClassID = licenseClassID;
           this.IssueDate = issueDate;
           this.ExpirationDate = expirationDate;
           this.Notes = notes;
           this.PaiedFees = paiedFees;
           this.IsActive = isActive;
           this.IssueReason = issueReason;
           this.CreatedByUserID = createdByUserID;
          _Driver = clsDriver.DriverFindByID(DriverID);
          _Application = clsApplication.FindApplicationByID(ApplicationID);
          _LicenseClass = clsLicenseClass.FindLicenseClasseByID(LicenseClassID);
          _Mode = enMode.Update;
           this.RenewedLicenseID = DVDLAccessDataTier.clsLicensesData.GetRenewdLicenseID(licenseClassID, DriverID); ;
           this.ReplacedLicenseID = DVDLAccessDataTier.clsLicensesData.GetReplacedLicenseID(licenseClassID, DriverID);
           if(clsLicense.IsLicenseDetained(this.LicenseID)) this.DetainedLicense = clsDetainLicense.GetDetainLicenseByLicenseID(this.LicenseID);


        }
        public static int GetLicenseIDByApplication(int LicenseClassID,int ApplicationID) 
        {
            return DVDLAccessDataTier.clsLicensesData.GetLicenseIDByApplicationID(LicenseClassID, ApplicationID);
        }
        public static DataTable GetAllLicenseForPerson(int PersonID) 
        {
            return DVDLAccessDataTier.clsLicensesData.GetAllLicensesForPerson(PersonID);
        
        }
        public static DataTable GetAllLicenses() { return DVDLAccessDataTier.clsLicensesData.GetAllLicensesFormated(); }
        public static clsLicense GetLicenseByID(int LicenseID) 
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpireDate = DateTime.Now;
            string Notes = "";
            Decimal PaiedFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;
            if (DVDLAccessDataTier.clsLicensesData.FindLicenseByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpireDate, ref Notes, ref PaiedFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpireDate, Notes, PaiedFees, IsActive, IssueReason, CreatedByUserID);
            }
            else return null;
        }
        private bool _AddNewLicense(int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime expirationDate, string Notes, Decimal paiedFees, bool isActive, byte issueReason, int createdByUserID) 
        {
        this.LicenseID = DVDLAccessDataTier.clsLicensesData.AddLicense(ApplicationID,DriverID,LicenseClassID,IssueDate,expirationDate,Notes,paiedFees,isActive, issueReason, createdByUserID);
            return (this.LicenseID != -1);
        }
        private bool _UpdateLicense(int licenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime expirationDate, string Notes, Decimal paiedFees, bool isActive, byte issueReason, int createdByUserID)
        {
            return DVDLAccessDataTier.clsLicensesData.UpdateLicense(licenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, expirationDate, Notes, paiedFees, isActive, issueReason, createdByUserID);
          
        }
        public bool DeactivateCurrentLicnese() 
        {
            return (DVDLAccessDataTier.clsLicensesData.DeactivateLicense(this.LicenseID));
        }
        public static bool IsLicenseDetained(int LicenseID) { return DVDLAccessDataTier.clsLicensesData.isLicenseDetained(LicenseID); }
        public int DetainLicense(Decimal FineFees,int CreatedByUserID) 
        {
            clsDetainLicense DetainLicense = new clsDetainLicense();
            DetainLicense.FineFees = FineFees;
            DetainLicense.DetainDate = DateTime.Now;
            DetainLicense.CreatedByUserID = CreatedByUserID;
            DetainLicense.IsReleased = false;
            DetainLicense.LicenseID = this.LicenseID;
            if (!DetainLicense.Save()) { return -1; }
            DeactivateCurrentLicnese();
            this.DetainedLicense = DetainLicense;
            return DetainLicense.DetainID;
        
        }
        public bool ReleaseLicense(int ReleasedByUserID, ref int ApplicationID)
        {
            clsApplication Application  = new clsApplication();
            Application.CreatedByUserID = ReleasedByUserID;
            Application.PaiedFees = clsApplicationType.FindApplicationTypeByID(((int)clsApplicationType.enApplicationTypeID.ReleaseDetainLicense)).Fees;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationStatus = (int)clsApplication.enStatusMode.Completed;
            Application.ApplicationTypeID = clsApplicationType.FindApplicationTypeByID(((int)clsApplicationType.enApplicationTypeID.ReleaseDetainLicense)).ID;
            Application.LastStatusDate = DateTime.Now;
            Application.ApplicationPersonID = this.SelectedDriver.PersonID;
            if (!Application.Save()) { ApplicationID = -1; return false; }
            ApplicationID = Application.ApplicationID;
           return  this.DetainedLicense.ReleaseDetainedLicense(ReleasedByUserID, Application.ApplicationID);
        }
        public  clsLicense RenewLicense(string Notes , int CreatedByUserID) 
        {
            clsApplication Application = new clsApplication();
            Application.CreatedByUserID = CreatedByUserID;
            Application.PaiedFees = clsApplicationType.FindApplicationTypeByID(((int)clsApplicationType.enApplicationTypeID.ReleaseDetainLicense)).Fees;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationStatus = (int)clsApplication.enStatusMode.Completed;
            Application.ApplicationTypeID = clsApplicationType.FindApplicationTypeByID(((int)clsApplicationType.enApplicationTypeID.ReleaseDetainLicense)).ID;
            Application.LastStatusDate = DateTime.Now;
            Application.ApplicationPersonID = this.SelectedDriver.PersonID;
            if (!Application.Save()) { return null; }
            ApplicationID = Application.ApplicationID;

            clsLicense NewLicenese      = new clsLicense();
            NewLicenese.ApplicationID   = Application.ApplicationID;
            NewLicenese.DriverID        = this.DriverID;
            NewLicenese.LicenseClassID  = this.LicenseClassID;
            NewLicenese.IssueDate       = DateTime.Now;
            int Length                  = this.SelectedLicenseClass.DefaultValidityLength;
            NewLicenese.ExpirationDate  = DateTime.Now.AddYears(Length);
            NewLicenese.PaiedFees       = this.SelectedLicenseClass.ClassFees;
            NewLicenese.IssueReason     = (int)clsLicense.enIssueReason.Renew;
            NewLicenese.IsActive        = true;
            NewLicenese.Notes           = Notes;
            NewLicenese.CreatedByUserID = CreatedByUserID;

            if (!NewLicenese.Save()) { return null; }
            this.DeactivateCurrentLicnese();

            return NewLicenese;

        }
        public clsLicense ReplaceLicense(enIssueReason IssueRease, int CreatedByUserID)
        {
            clsApplication Application = new clsApplication();
            Application.CreatedByUserID = CreatedByUserID;
            Application.PaiedFees = clsApplicationType.FindApplicationTypeByID(((int)clsApplicationType.enApplicationTypeID.ReleaseDetainLicense)).Fees;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationStatus = (int)clsApplication.enStatusMode.Completed;
            if (IssueRease == enIssueReason.LostReplacement) { Application.ApplicationTypeID = clsApplicationType.FindApplicationTypeByID(((int)clsApplicationType.enApplicationTypeID.ReplaceLostLicense)).ID; }
            else { Application.ApplicationTypeID = clsApplicationType.FindApplicationTypeByID(((int)clsApplicationType.enApplicationTypeID.ReplaceDamagedLicense)).ID; }
            Application.LastStatusDate = DateTime.Now;
            Application.ApplicationPersonID = this.SelectedDriver.PersonID;
            if (!Application.Save()) { return null; }
            ApplicationID = Application.ApplicationID;

            clsLicense NewLicenese = new clsLicense();
            NewLicenese.ApplicationID = Application.ApplicationID;
            NewLicenese.DriverID = this.DriverID;
            NewLicenese.LicenseClassID = this.LicenseClassID;
            NewLicenese.IssueDate = DateTime.Now;
            int Length = this.SelectedLicenseClass.DefaultValidityLength;
            NewLicenese.ExpirationDate = DateTime.Now.AddYears(Length);
            NewLicenese.PaiedFees = this.SelectedLicenseClass.ClassFees;
            NewLicenese.IssueReason = (int)clsLicense.enIssueReason.Renew;
            NewLicenese.IsActive = true;
            NewLicenese.Notes = Notes;
            NewLicenese.CreatedByUserID = CreatedByUserID;

            if (!NewLicenese.Save()) { return null; }
            this.DeactivateCurrentLicnese();

            return NewLicenese;

        }
        
        public bool IsLicneseExpired() 
        {
            return (this.ExpirationDate < DateTime.Now);
        }
        public bool IsLicenseRenewd()
        {
            return (this.RenewedLicenseID != -1 && this.RenewedLicenseID != this.LicenseID);
        }
        public bool IsLicenseReplaced()
        {
            return (this.ReplacedLicenseID != -1 && this.ReplacedLicenseID != this.LicenseID);
        }
        public static  bool IsLicenseExsist(int LicenseID) { return  clsLicensesData.IsLicneseExsist(LicenseID); }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                  {
                        if (_AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaiedFees, this.IsActive, this.IssueReason, this.CreatedByUserID))
                        {
                            _Mode = enMode.Update;
                        return true;
                        }
                  }
                break;

                case enMode.Update:
                    {
                        return _UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaiedFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
                    }
            }
            return false;
        }


    }
}

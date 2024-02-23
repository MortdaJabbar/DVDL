using DVDLAccessDataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinesLogicTier
{
    public class clsLocalDrivingLicense
    {

        public enum enLocalDrivingLicense {AddNewLocalDrivingLicense = 1 , UpdateLocalDrivingLicense=2 }
        public enLocalDrivingLicense Mode;
        private clsLicenseClass _licenseClass;
        public clsLicenseClass LicenseCLass { get{ return _licenseClass; } }
        
        private clsApplication _Application;
        public clsApplication Application { get { return _Application; } }
        public int LocalDrivingLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public clsLocalDrivingLicense() 
        {
            this.LocalDrivingLicenseID = -1;
            this.ApplicationID         = -1;
            this.LicenseClassID        = -1;
            _Application = new clsApplication();
            _licenseClass = new clsLicenseClass();
            this.Mode = enLocalDrivingLicense.AddNewLocalDrivingLicense;
        }
        public clsLocalDrivingLicense(int LocalDrivingLicenseID , int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseID = LocalDrivingLicenseID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            _Application = clsApplication.FindApplicationByID(this.ApplicationID);
            _licenseClass = clsLicenseClass.FindLicenseClasseByID(this.LicenseClassID);
            this.Mode = enLocalDrivingLicense.UpdateLocalDrivingLicense;
        }
        private bool _AddNewLocalDrivingLicense(int ApplicationID, int LicenseClassID) 
        {
            this.LocalDrivingLicenseID = clsLocalDrivingLicenseData.AddLocalDrivingLicense(ApplicationID, LicenseClassID);
            return (LocalDrivingLicenseID != -1);

        }
        private bool _UpdateLocalDrivingLicense(int LocalDrivingLicenseID, int ApplicationID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseData.UpdateLocalDrivingLicense(LocalDrivingLicenseID,ApplicationID, LicenseClassID);
 
        }
        public static clsLocalDrivingLicense FindLocalDrivingLicense(int LocalDrivingLicenseID) 
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;
            if(clsLocalDrivingLicenseData.FindLocalDrivingLicenseByID(LocalDrivingLicenseID, ref ApplicationID, ref LicenseClassID))
            {
                return new clsLocalDrivingLicense(LocalDrivingLicenseID, ApplicationID, LicenseClassID);
            }
            return null;
        }
        public static clsLocalDrivingLicense FindLocalDrivingLicenseByLicenseClassID(int LicenseClassID , int PersonID)
        {
            int ApplicationID = -1;
            int LocalDrivingLicenseID = -1;
            
            if (clsLocalDrivingLicenseData.FindLocalDrivingLicenseByLiceseneClassIDAndPersonID(LicenseClassID, PersonID, ref LocalDrivingLicenseID, ref ApplicationID))
            {
                return new clsLocalDrivingLicense(LocalDrivingLicenseID, ApplicationID, LicenseClassID);
            }
            return null;
        }
        public static bool IsLocalDrivingLiceseApplicationExsist(int LocalDrivingLicenseApplicationID) 
        {
            return DVDLAccessDataTier.clsLocalDrivingLicenseData.IsLocalDrivingLicenesApplicationExsist(LocalDrivingLicenseApplicationID);
        }
        public  int GetNumberOfPassedTests() { return DVDLAccessDataTier.clsLocalDrivingLicenseData.GetCountOfPassedTestsForLDLA(this.LocalDrivingLicenseID); }
        public static DataTable GetAllLDLApplications() 
        {
            return clsLocalDrivingLicenseData.GetAllLocalDrivingLicenses();
        }
        public static DataTable GetAllLDLApplicationsFormated()
        {
            return clsLocalDrivingLicenseData.GetAllLocalDrivingLicensesFormated();
        }
        public int IssueLicenseForFirstTime(string Notes , int CreatedByUserID) 
        {
            int DriverID = -1;
            clsDriver Driver = clsDriver.DriverFindByPersonID(this.Application.ApplicationPersonID);
            if (Driver == null)
            {
                Driver = new clsDriver();
                Driver.CreatedByUserID = CreatedByUserID;
                Driver.CreatedDate = DateTime.Now;
                Driver.PersonID = this.Application.ApplicationPersonID;
                if (Driver.Save()) { DriverID = Driver.DriverID; }
                else return -1;
            }
            else { DriverID = Driver.DriverID; }

            clsLicense LicenseForFirstTime =new  clsLicense();
            LicenseForFirstTime.DriverID = DriverID;
            LicenseForFirstTime.ApplicationID = this.ApplicationID;
            LicenseForFirstTime.LicenseClassID = this.LicenseClassID;
            LicenseForFirstTime.IssueDate = DateTime.Now;
            LicenseForFirstTime.ExpirationDate = DateTime.Now.AddYears(this.LicenseCLass.DefaultValidityLength);
            LicenseForFirstTime.Notes = Notes;
            LicenseForFirstTime.PaiedFees = this.LicenseCLass.ClassFees;
            LicenseForFirstTime.IsActive = true;
            LicenseForFirstTime.IssueReason = (int)clsLicense.enIssueReason.FirstTime;
            LicenseForFirstTime.CreatedByUserID = CreatedByUserID;

            if (!LicenseForFirstTime.Save()) return -1;
            if (!this.Application.SetApplicationCompleted()) return -1;
            return LicenseForFirstTime.LicenseID;

        } 
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID) 
        {
            return DVDLAccessDataTier.clsLocalDrivingLicenseData.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }
        public  int GetActiveLicenseIDForLicenseClass() { return clsLocalDrivingLicenseData.GetActiveLicenseID(this.LicenseClassID); }
        public bool PassedAllTest() 
        {
            return (clsLocalDrivingLicenseData.GetCountOfPassedTestsForLDLA(this.LocalDrivingLicenseID)==3);
        }
        public bool Save() 
        {
            switch (Mode) 
            {
                case enLocalDrivingLicense.AddNewLocalDrivingLicense:
                    {
                        if (_AddNewLocalDrivingLicense(this.ApplicationID, this.LicenseClassID)) { Mode = enLocalDrivingLicense.UpdateLocalDrivingLicense; return true; }
                        return false;
                    }
                case enLocalDrivingLicense.UpdateLocalDrivingLicense: { return _UpdateLocalDrivingLicense(this.LocalDrivingLicenseID, this.ApplicationID, this.LicenseClassID); }
                    
            }
            
            return false;
        
        }
   
    
    }
}

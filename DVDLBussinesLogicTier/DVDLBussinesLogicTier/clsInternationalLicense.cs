using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinesLogicTier
{
    public class clsInternationalLicense
    {
        private enum enMode { Add = 1, Update = 2 }
        
        private enMode Mode;
        private clsApplication _Application { get; set; }
        public clsApplication Application { get { return _Application; } }
        private clsLicense _License { get; set; }
        public clsLicense License { get { return _License; } }
        private clsDriver _Driver { get; set; }
        public clsDriver Driver { get { return _Driver; } }
        private clsUser _User { get; set; }
        public clsUser User { get { return _User; } }

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public string IsActiveText{ get{return (IsActive == true) ? "Yes" : "Now"; } }
        public int CreatedByUserID { get; set; }
        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            this._Application = null;
            this._License = null;
            this._Driver = null;
            this._User = null;
            this.Mode = enMode.Add;
        }
        public clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int LocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LocalLicenseID = LocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this._Application = clsApplication.FindApplicationByID(ApplicationID);
            this._License = clsLicense.GetLicenseByID(LocalLicenseID);
            this._Driver = clsDriver.DriverFindByID(DriverID);
            this._User = clsUser.FindUserByUserID(CreatedByUserID);
            this.Mode = enMode.Update;
        }
        private bool _AddNewInternationalLicense() 
        { 
         this.InternationalLicenseID = DVDLAccessDataTier.clsInternationalLicenseData.AddNewInternatioanlLicense(this.ApplicationID,this.DriverID,this.LocalLicenseID,this.IssueDate,this.ExpirationDate,this.IsActive,this.CreatedByUserID);
            return (this.InternationalLicenseID != -1);
        }
        private bool _UpdateInternationalLicense()
        {
           return  DVDLAccessDataTier.clsInternationalLicenseData.UpdateInternationalLiceseByID(this.InternationalLicenseID,this.ApplicationID, this.DriverID, this.LocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
          
        }
        public static clsInternationalLicense FindInternationalNumber(int InternationalLicenseID) 
        {
            int ApplicationID = -1, DriverID = -1, CreatedByUser = -1, IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            if (DVDLAccessDataTier.clsInternationalLicenseData.FindInternationalLiceseByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUser))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUser);
            }
          return null;
        }
        public static clsInternationalLicense FindInernationalLicenseByLocalLicenseID(int IssuedUsingLocalLicenseID) 
        {
            int ApplicationID = -1, DriverID = -1, CreatedByUser = -1, InternationalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            if (DVDLAccessDataTier.clsInternationalLicenseData.FindInternationalLiceseByLocalLicenseID(IssuedUsingLocalLicenseID, ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUser))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUser);
            }
            return null;

        }
        public static bool IsInternationalLicenseExsist(int InternationalLicenseID) { return DVDLAccessDataTier.clsInternationalLicenseData.IsInternationalLicenseExsist(InternationalLicenseID); }
        public static DataTable GetAllInternationalLicensesForPerson(int PersonID) 
        {
            return DVDLAccessDataTier.clsInternationalLicenseData.GetAllInternationalLicensesForPerson(PersonID);
        }
        public static DataTable GetAllInternationalLicenseFormated() { return DVDLAccessDataTier.clsInternationalLicenseData.GetAllInternationalLicensesFormated(); }
        public bool Save() 
        {
            switch (this.Mode) 
            {
                case enMode.Add:
                 {
                        if (_AddNewInternationalLicense()) { Mode = enMode.Update; return true; }
                 }
                    break;
                case enMode.Update:
                    {
                        return _UpdateInternationalLicense();
                    }
                   
            }
            return false;
        }
    }
}

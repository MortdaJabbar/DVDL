using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinesLogicTier
{
    public class clsApplicationType
    {
        public enum enApplicationTypeID {NewLocalLicense = 1 ,RenewLicense = 2,ReplaceLostLicense=3, ReplaceDamagedLicense=4 ,ReleaseDetainLicense=5,NewInternationalLicens=6,RetakeTestApplication=8}
        public enum  enApplicationTypeMode { AddNew = 1, Update = 2 };
        public enApplicationTypeMode Mode = enApplicationTypeMode.Update;
        public int ID {get; set;}
        public string ApplicationTypeTitle { get; set; }
        public Decimal Fees { get; set; }

        public clsApplicationType() { this.ID = -1; this.Fees = 0; this.ApplicationTypeTitle = ""; Mode = enApplicationTypeMode.AddNew; }
        public clsApplicationType(int ID , string ApplicationTypeTitle, Decimal Fees) { this.ID = ID; this.Fees = Fees; this.ApplicationTypeTitle = ApplicationTypeTitle; this.Mode = enApplicationTypeMode.Update; }
        public static DataTable GetAllApplicationsTypes() 
        {
            return DVDLAccessDataTier.clsApplicationTypes.GellApplicationTypes();
        }
        public static clsApplicationType FindApplicationTypeByID(int ID)
        {
          string  ApplicationTypeTitle = "";
          Decimal ApplicationFees = 0;
          bool Found = DVDLAccessDataTier.clsApplicationTypes.FindApplicationTyepByID(ID, ref ApplicationTypeTitle, ref ApplicationFees);
            if (Found) 
            {
                return new clsApplicationType(ID, ApplicationTypeTitle, ApplicationFees);
            }

            return null;
        }
        private static bool _UpdateApplicationType(int ApplicationID, string applicationType, Decimal fees) 
        {
            return DVDLAccessDataTier.clsApplicationTypes.UpdateApplicationType(ApplicationID, applicationType, fees);
        }
        public bool Save() 
        {
            switch (Mode) 
            {
                case enApplicationTypeMode.Update: return _UpdateApplicationType(this.ID, this.ApplicationTypeTitle, this.Fees);
                    
            
            }

            return false;
        }
    }
}

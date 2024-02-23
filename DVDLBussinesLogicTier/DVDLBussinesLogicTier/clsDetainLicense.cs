using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinesLogicTier
{
    public class clsDetainLicense
    {
        public enum enMode {Add=1,Update=2}
        
        private enMode _Mode;
       
        private clsApplication _ReleaseApplication { get; set; }
        private clsUser _User { get; set; }
       
        public clsApplication Application { get { return _ReleaseApplication; } }
        public clsUser User { get { return _User; } }
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public Decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        public clsDetainLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate=DateTime.MaxValue;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MaxValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
           
            _ReleaseApplication = null;
            _User = null;
            this._Mode = enMode.Add;
        }
        public clsDetainLicense(int DetainID, int LicenseID, DateTime DetainDate, Decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            
            _ReleaseApplication = clsApplication.FindApplicationByID(ReleaseApplicationID);
            _User = clsUser.FindUserByUserID(CreatedByUserID);
            this._Mode = enMode.Update;
        }
        public static bool IsLicenseDetained(int LicneseID) 
        {
            return DVDLAccessDataTier.clsDetainedLicenseData.IsLicenseDetained(LicneseID);
        }
        private bool _AddNewDetainLicense() 
        {
            this.DetainID = DVDLAccessDataTier.clsDetainedLicenseData.AddDetainLicnese(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
            return (this.DetainID != -1);
        }
        private bool _UpdateDetainLicense() 
        {
            return DVDLAccessDataTier.clsDetainedLicenseData.UpdateDetainLicnese(this.DetainID,this.LicenseID,this.DetainDate,this.FineFees,this.CreatedByUserID,this.IsReleased,this.ReleaseDate,this.ReleasedByUserID,this.ReleaseApplicationID);
        }
        public  static clsDetainLicense GetDetainLicenseByLicenseID(int LicenseID) 
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate=DateTime.MinValue;
            Decimal FineFees = 0; 
            DateTime ReleaseDate = DateTime.MinValue; 
            bool IsReleased = false;
            if (DVDLAccessDataTier.clsDetainedLicenseData.FindDetainLicenseByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }return null;
        
        }
        public static int GetDetainIDByLicenseID(int LicenseID) 
        {
            return clsDetainLicense.GetDetainIDByLicenseID(LicenseID);
        }
        public static clsDetainLicense GetDetainLicenseByID(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.MinValue;
            Decimal FineFees = 0;
            DateTime ReleaseDate = DateTime.MinValue;
            bool IsReleased = false;
            if (DVDLAccessDataTier.clsDetainedLicenseData.FindDetainLicenseByID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            return null;

        }
        public static DataTable GetAllDetainedLicenses() 
        {
            return DVDLAccessDataTier.clsDetainedLicenseData.GetAllDetainedLicenses();
        
        }
        public bool ReleaseDetainedLicense(int ReleasedByUserID , int ApplicationID) 
        {
          
            
            this.ReleaseDate = DateTime.Now;
            this.IsReleased = true;
            this.ReleaseApplicationID = ApplicationID;
            this.ReleasedByUserID = ReleasedByUserID;
            return this.Save();
        }
        public bool Save() 
        {
            switch (_Mode) 
            {
                case enMode.Add: 
                    {
                        if (_AddNewDetainLicense()) { _Mode = enMode.Update; return true; }
                    }break;

                case enMode.Update:
                    {
                        return _UpdateDetainLicense();
                    }    
            }
            return false;
        }
    


    }
}

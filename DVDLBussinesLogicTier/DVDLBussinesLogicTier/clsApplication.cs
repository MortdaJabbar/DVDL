using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDLAccessDataTier;
namespace DVDLBussinesLogicTier
{
    public class clsApplication
    {
        
        public enum enApplicationMode {AddNewApplication = 1 , UpdateApplication =2 }
        public enApplicationMode ApplicationMode { get; set; }
        public enum enStatusMode {New=1, Cancelled=2, Completed = 3 }
        public enStatusMode StatusMode { get; set; }
        private  clsPerson _Person { get; set; }
        public clsPerson SelectedPerson { get { return _Person; } }
        private clsApplicationType _ApplicationType { get; set; }
        public clsApplicationType SelectedApplicationType { get { return _ApplicationType; } }
        public int ApplicationID { get; set; }
        public int ApplicationPersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }
        public Decimal PaiedFees { get; set; }
        public string StatusText {


            get
            { 
                switch (ApplicationStatus) 
                { case 1: return "New";
                  case 2:return "Canceled";
                  case 3: return "Completed";
                }
                return "Unknown";
            }
            
            }
        public clsApplication() 
        {
            this.ApplicationID       = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationTypeID   = -1;
            this.CreatedByUserID     = -1;
            this.ApplicationDate     = DateTime.Now;
            this.LastStatusDate      = DateTime.Now;
            this.ApplicationStatus   = 1;
            this.PaiedFees           = 0;
            this.ApplicationMode     = enApplicationMode.AddNewApplication;
            this.StatusMode = (enStatusMode)this.ApplicationStatus;
            this._Person = new clsPerson();
            this._ApplicationType = new clsApplicationType() ;
        }
        public clsApplication(int ApplicationID,int ApplicationPersonID,DateTime ApplicationDate,int ApplicationTypeID,byte ApplicationStatus,DateTime LastStatusDate,Decimal PaiedFees,int CreatedByUserID)
        {
            this.ApplicationID       = ApplicationID;
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationTypeID   = ApplicationTypeID;
            this.CreatedByUserID     = CreatedByUserID;
            this.ApplicationDate     = ApplicationDate;
            this.LastStatusDate      = LastStatusDate;
            this.ApplicationStatus   = ApplicationStatus;
            this.PaiedFees           = PaiedFees;
            this.ApplicationMode = enApplicationMode.UpdateApplication;
            this.StatusMode = (enStatusMode)this.ApplicationStatus;
            this._Person = clsPerson.FindPersonByID(ApplicationPersonID);
            this._ApplicationType = clsApplicationType.FindApplicationTypeByID(ApplicationTypeID);
        }
        public static DataTable GetAllApplications() 
        {
            return DVDLAccessDataTier.clsApplicationsData.GellApplications();
        }
        public static clsApplication  FindApplicationByID(int ApplicationID)
        {
            int ApplicationPersonID = -1;
            int ApplicationTypeID   = -1;
            int CreatedByUserID = -1;
            byte AppStatus = 0;
            DateTime ApplicationDate = DateTime.Now;
            DateTime LastDate = DateTime.Now;
            Decimal PaiedFees = 0;
           
            if (DVDLAccessDataTier.clsApplicationsData.FindApplicationByID(ApplicationID, ref ApplicationPersonID, ref ApplicationDate, ref ApplicationTypeID, ref AppStatus, ref LastDate, ref PaiedFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID, AppStatus, LastDate, PaiedFees, CreatedByUserID);
            }
            else return null;
        }
        public static clsApplication FindApplicationByPersonID(int PersonID)
        {
            int ApplicationID = -1;
            int ApplicationTypeID = -1;
            int CreatedByUserID = -1;
            byte AppStatus = 0;
            DateTime ApplicationDate = DateTime.Now;
            DateTime LastDate = DateTime.Now;
            Decimal PaiedFees = 0;

            if (DVDLAccessDataTier.clsApplicationsData.FindApplicationByPersonID(PersonID, ref ApplicationID, ref ApplicationDate, ref ApplicationTypeID, ref AppStatus, ref LastDate, ref PaiedFees, ref CreatedByUserID))
            {
                return new clsApplication(PersonID, ApplicationID, ApplicationDate, ApplicationTypeID, AppStatus, LastDate, PaiedFees, CreatedByUserID);
            }
            else return null;
        }
        public bool _AddNewApplication(int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, Decimal PaiedFees, int CreatedByUserID) 
        {
            this.ApplicationID =  DVDLAccessDataTier.clsApplicationsData.AddApplication(ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaiedFees, CreatedByUserID);
            return (ApplicationID != -1);
        }
        public bool __UpdateApplication(int ApplicationID,int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, Decimal PaiedFees, int CreatedByUserID)
        {
           
            return DVDLAccessDataTier.clsApplicationsData.UpdateApplication(ApplicationID,ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaiedFees, CreatedByUserID);
           
        }
        public bool SetApplicationCompleted() { return clsApplicationsData.UpdateApplicationStatusMode(this.ApplicationID, (byte)enStatusMode.Completed); }
        public bool Save() 
        {
            
            switch (ApplicationMode) 
            {
                case enApplicationMode.AddNewApplication: 
                    {
                        if (_AddNewApplication(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaiedFees, this.CreatedByUserID) )
                        {
                            this.ApplicationMode = enApplicationMode.UpdateApplication;
                            return true;
                        }
                    }break;

                    case enApplicationMode.UpdateApplication: 
                    {
                        return __UpdateApplication(this.ApplicationID, this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaiedFees, this.CreatedByUserID);
                    }
            
            }
            return false;
        }

    }
}

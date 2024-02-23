using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVDLBussinesLogicTier
{
    public class clsDriver
    {
        public enum enMode {Add=1,Update=2}
        
        private enMode Mode;
        
        private clsPerson _Person;
        public  clsPerson Person { get { return _Person; } }
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set;}
        public DateTime CreatedDate { get; set; }
        public clsDriver() { this.DriverID = -1; this.PersonID = -1; this.CreatedDate = DateTime.Now; this.CreatedByUserID = -1; _Person = null; Mode = enMode.Add; }
        public clsDriver(int DriverID ,int PersonID , int CreatedByUserID , DateTime CreatedDate) { this.DriverID = DriverID; this.PersonID = PersonID; this.CreatedDate = CreatedDate; this.CreatedByUserID = CreatedByUserID; _Person = clsPerson.FindPersonByID(PersonID); Mode = enMode.Update; }   
        public static DataTable GetAllDriversFormated() 
        {
           return  DVDLAccessDataTier.clsDrivers.GetAllDriversFormated();
        
        }
        public static clsDriver DriverFindByID(int DriverID) 
        {
            int PersonID = -1,CreatedByUserID=-1;
            
            DateTime CreatedDate=DateTime.Now;
            if (DVDLAccessDataTier.clsDrivers.FindDriverByID(DriverID, ref CreatedByUserID, ref PersonID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else return null;
        }
        public static clsDriver DriverFindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;

            DateTime CreatedDate = DateTime.Now;
            if (DVDLAccessDataTier.clsDrivers.FindDriverByPersonID(PersonID, ref CreatedByUserID, ref DriverID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else return null;
        }
        private bool _AddNewDriver(int PersonID,int CreatedByUserID,DateTime CreatedDate) 
        {
            this.DriverID = DVDLAccessDataTier.clsDrivers.AddDriver(CreatedByUserID, PersonID, CreatedDate);
            return (this.DriverID != -1);
        }
        public static bool IsDriverExisitByDriverID(int DriverID) 
        {
            return DVDLAccessDataTier.clsDrivers.IsDriverExsistByDriverID(DriverID);
        }
        public static bool IsDriverExisitByPersonID(int PersonID)
        {
            return DVDLAccessDataTier.clsDrivers.IsDriverExsistByPersonID(PersonID);
        }
        public static bool DeleteDriver(int DriverID) { return DVDLAccessDataTier.clsDrivers.DeleteDriver(DriverID); }
        private bool _UpdateDriver(int DriverID,int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            return  DVDLAccessDataTier.clsDrivers.UpdateDriver(DriverID,CreatedByUserID, PersonID, CreatedDate);
        }
       
        public bool Save() 
        {
            switch (Mode) 
            {
                case enMode.Add: 
                    {
                        if (_AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate)) { Mode = enMode.Update; return true; }
                    }break;

                case enMode.Update:
                    {
                        return _UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
                    }
            }
            return false;
        }

    }
}

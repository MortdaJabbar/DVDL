using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinesLogicTier
{
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode;
        
        private clsLocalDrivingLicense _LocalDrivingLicenseApplication;
        public clsLocalDrivingLicense LDLApplication { get { return _LocalDrivingLicenseApplication; } }
        
        private clsTestType _TestType;
        public clsTestType TestType { get { return _TestType; } }
        public int TestAppointmentID { get; set; }
        public int CreatedByUserID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Decimal PaidFees { get; set; }
        public bool  IsLocked { get; set; }
        public int   RetakeTestApplicationID { get; set; }
        public clsTestAppointment() { 
            Mode = enMode.AddNew; 
            this.TestAppointmentID = -1;
            this.CreatedByUserID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.TestTypeID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            _LocalDrivingLicenseApplication = new clsLocalDrivingLicense();
            _TestType = new clsTestType();
        }
        public clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, Decimal PaiedFees, int CreatedByUserID,bool IsLocked,int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaiedFees;
            this.IsLocked = IsLocked;
            this.CreatedByUserID = CreatedByUserID;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            Mode = enMode.Update;
            this._LocalDrivingLicenseApplication = clsLocalDrivingLicense.FindLocalDrivingLicense(LocalDrivingLicenseApplicationID);
            this._TestType = clsTestType.GetTestTypeByID(TestTypeID);
        }
        public static clsTestAppointment FindTestAppointmentByID(int TestAppointmentID)
        {
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            Decimal PaiedFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            bool Found = DVDLAccessDataTier.clsTestAppointmentData.FindTestAppointmentByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaiedFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID);

            if (Found)
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate, PaiedFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else return null; 
        }
        public static DataTable GetAllAppointmentsForLocalDrivingLicense(int LocalDrivingLicenseApplicationID,int TestTypeID) { return DVDLAccessDataTier.clsTestAppointmentData.GetAllTestApointmentForLocalDrivingLicense(LocalDrivingLicenseApplicationID, TestTypeID); }
        public static DataTable GetAllAppointments() { return DVDLAccessDataTier.clsTestAppointmentData.GetAllTestAppointment(); }
        public static DataTable GetAllAppointmentsFormated() { return DVDLAccessDataTier.clsTestAppointmentData.GetAllTestAppointmentFormated(); }
        private bool _AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, Decimal PaidFees, int CreatedByUserID, bool IsLocked,int RetakeTestApplicationID)
        {

            this.TestAppointmentID = DVDLAccessDataTier.clsTestAppointmentData.AddTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID,AppointmentDate, PaidFees, CreatedByUserID, IsLocked,RetakeTestApplicationID);
            return (TestAppointmentID != -1);

        }
        private bool _UpdateTestAppointment(int TestAppointmentID,int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, Decimal PaidFees, int CreatedByUserID, bool IsLocked,int RetakeTestApplicationID)
        {

           return DVDLAccessDataTier.clsTestAppointmentData.UpdateTestAppointment(TestAppointmentID,TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
          

        }
        public static bool DoesApplicationHasActiveAppointment(int LocalDrivingLicenseApplicationID,int TestTypeID) 
        {
            return DVDLAccessDataTier.clsTestAppointmentData.IsLocalDrivingLicenesAppointmentActive(LocalDrivingLicenseApplicationID,TestTypeID);
        
        }
        public static bool IsPersonHasPassedTheTest( int LocalDrivingLicenseApplicationID, int TestTypeID) 
        {
            return DVDLAccessDataTier.clsTestAppointmentData.IsLocalDrivingLicneseAppointmentHasPassedTest(LocalDrivingLicenseApplicationID, TestTypeID);
        }
        public bool Save() 
        {
            switch (Mode) 
            {

                case enMode.AddNew: 
                    {
                        if (_AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,this.RetakeTestApplicationID))
                        { Mode = enMode.Update; return true; }
                    }
                    break;
                case enMode.Update: { return _UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,this.RetakeTestApplicationID); ; }
            
            }

            return false;   
        
        }
        public   int GetNumberOfFailedTestsForLDLA() 
        {
            return  DVDLAccessDataTier.clsTestAppointmentData.GetCountOfFailedTestsForLDLATestType(this.TestTypeID, this.LocalDrivingLicenseApplicationID); 
        }
      
        public static  int GetTotalOfFailedTestsForLDLA(int TestTypeID,int LocalDrivingLicenseApplicationID)
        {
            return DVDLAccessDataTier.clsTestAppointmentData.GetCountOfFailedTestsForLDLATestType(TestTypeID, LocalDrivingLicenseApplicationID);

        }
    }
}

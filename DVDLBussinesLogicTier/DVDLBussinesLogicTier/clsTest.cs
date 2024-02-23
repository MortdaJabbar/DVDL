using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinesLogicTier
{
    public  class clsTest
    {
    public enum enTestMode {Add=1 , Update=2 }
    public enTestMode Mode { get; set; }
    private clsTestAppointment _TestAppointment;
    public clsTestAppointment TestAppointment { get { return _TestAppointment; } }
    public int TestID { get; set; }
    public int TestAppointmentID { get; set; }
    public int CreatedByUserID { get; set; }
    public bool TestResult { get; set; }
    public string Notes { get; set; }
    public clsTest() { this.TestID = -1; this.TestAppointmentID = -1; this.CreatedByUserID = -1; this.Notes = ""; this.TestResult = false;  this.Mode = enTestMode.Add; this._TestAppointment = new clsTestAppointment(); }
    public clsTest(int TestID , int TestAppointmentID,bool TestResult,string Notes,int CreatedByUserID) { this.TestID = TestID; this.TestAppointmentID = TestAppointmentID; this.CreatedByUserID = CreatedByUserID; this.Notes = Notes; this.TestResult = TestResult; this.Mode = enTestMode.Update; this._TestAppointment = clsTestAppointment.FindTestAppointmentByID(TestAppointmentID); }
    public static clsTest FindTestByTestID(int TestID) 
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;
            if (DVDLAccessDataTier.clsTests.FindTestByID(TestID, ref TestAppointmentID,ref TestResult,ref Notes,ref CreatedByUserID)) 
            {
                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }return null;


        }
    private  bool _AddNewTest(int TestAppointmentID , bool TestResult,string Notes,int CreatedByUserID) 
    {
            this.TestID = DVDLAccessDataTier.clsTests.AddTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return (TestID!=-1);
    }
    public bool Save() 
        {
        switch(this.Mode) 
            {
                case enTestMode.Add: 
                    {
                    if(_AddNewTest(this.TestAppointmentID, this.TestResult,this.Notes,this.CreatedByUserID))
                     { this.Mode = enTestMode.Update; return true; }
                    }break;
            }

            return false;
        }



    }
}

using DVDL.Properties;
using DVDLBussinesLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL.Tests
{
    public partial class frmSechdualTest : Form
    {
        public delegate void DataBackHandler(object sendner, int TestAppointmentID);
        public event DataBackHandler DataBack;
        public enum enTestType {VisionTest=1,WrittenTest=2,StreetTest=3 }
        
        private enTestType _frmTestType;
 
        private clsLocalDrivingLicense _LocalDrivingLicense;

        private clsTestType _TestType; 
        
        private clsTestAppointment  _TestAppointment = new clsTestAppointment();
        
        private int _TestAppointmentID = -1;
        
        private  clsApplication _RetakeTestApplication;
        public enum enTestMode {TakeTest=1,RetakeTest=2 }
        
        private enTestMode _TestMode;
        public frmSechdualTest(clsLocalDrivingLicense LDLApplication,enTestType TestType,enTestMode TestMode)
        {
            InitializeComponent();
            _LocalDrivingLicense = LDLApplication;
            _TestMode          = enTestMode.TakeTest;
            _frmTestType       = TestType;
            _TestMode          = TestMode; 
            
            _TestAppointmentID = -1;
            
        }
        public frmSechdualTest(clsTestAppointment TestAppointment, enTestType TestType,enTestMode TestMode)
        {
            InitializeComponent();
            
            _TestAppointment = TestAppointment;
            _TestMode = TestMode;
            _TestAppointmentID = _TestAppointment.TestAppointmentID;
            _frmTestType = TestType;
            _LocalDrivingLicense = _TestAppointment.LDLApplication;
           
        }
        private void _InitalTestAppointment()
        {
            _TestType = clsTestType.GetTestTypeByID((int)_frmTestType);
            if (_TestMode == enTestMode.RetakeTest) _RetakeTestApplication = clsApplication.FindApplicationByID(8);
            switch (_frmTestType)
            {
                case enTestType.VisionTest:
                    {
                        pbTestImage.Image = Resources.Vision_512;
                        gbSechdualTest.Text = "Vision Test";
                    }
                    break;

                case enTestType.WrittenTest:
                    {
                        pbTestImage.Image = Resources.Written_Test_512;
                        gbSechdualTest.Text = "Written Test";
                    }
                    break;

                case enTestType.StreetTest:
                    {
                        pbTestImage.Image = Resources.driving_test_512;
                        gbSechdualTest.Text = "Street Test";
                    }
                    break;
            }

        }
        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            _InitalTestAppointment();
            if (_TestMode == enTestMode.TakeTest) _FillTakeTestInfo();
            else
            {
                _FillReTakeTestInfo();
                if (_TestAppointment.IsLocked)
                {
                    btnSave.Enabled = false;
                    dtDate.Enabled = false;
                    lbTakedTestTitle.Visible = true;

                }
            }


        }
        private void _FillTakeTestInfo()
        {
            
            
            lbLDLAppID.Text = _LocalDrivingLicense.LocalDrivingLicenseID.ToString();
            lbDrivingClass.Text = _LocalDrivingLicense.LicenseCLass.ClassName;
            lbName.Text = _LocalDrivingLicense.Application.SelectedPerson.FullName;
            lbFees.Text = _TestType.Fees.ToString();
            lbTotalFees.Text = _TestType.Fees.ToString();
            if (_TestAppointmentID != -1)
            {
                dtDate.Value = dtDate.MinDate = _TestAppointment.AppointmentDate;
                if (_TestAppointment.IsLocked)
                {
                    btnSave.Enabled = false;
                    dtDate.Enabled = false;
                    lbTakedTestTitle.Visible = true;
                    _TestAppointment.GetNumberOfFailedTestsForLDLA().ToString();
                }

            }
            else
            {
                dtDate.Value = dtDate.MinDate = DateTime.Now;
                lbTrial.Text = clsTestAppointment.GetTotalOfFailedTestsForLDLA(_TestType.ID, _LocalDrivingLicense.LocalDrivingLicenseID).ToString();
            }
        }    
        private void _FillReTakeTestInfo()
        {
            gbRetakeTestInfo.Enabled = true;
             
           
            lbLDLAppID.Text     = _LocalDrivingLicense.LocalDrivingLicenseID.ToString();
            lbDrivingClass.Text = _LocalDrivingLicense.LicenseCLass.ClassName;
            lbName.Text         = _LocalDrivingLicense.Application.SelectedPerson.FullName;
            lbFees.Text         = _TestType.Fees.ToString();
            lbTotalFees.Text    = (_TestType.Fees+clsApplicationType.FindApplicationTypeByID(8).Fees).ToString();
            lbRTestAppID.Text   = "N/A"; ;
            lbRAppFees.Text     = clsApplicationType.FindApplicationTypeByID(8).Fees.ToString();
            if (_TestAppointmentID != -1)
            {
                dtDate.Value = dtDate.MinDate = _TestAppointment.AppointmentDate;
                if (_TestAppointment.IsLocked)
                {
                    btnSave.Enabled = false;
                    dtDate.Enabled = false;
                    lbTakedTestTitle.Visible = true;
                }
                lbTrial.Text = _TestAppointment.GetNumberOfFailedTestsForLDLA().ToString();
            }
            else
            {
                dtDate.Value = dtDate.MinDate = DateTime.Now;
                lbTrial.Text = clsTestAppointment.GetTotalOfFailedTestsForLDLA(_TestType.ID, _LocalDrivingLicense.LocalDrivingLicenseID).ToString();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string ShowProperDoneMessage() 
        {
            if (_TestAppointmentID == -1)
            {
                return "\nTest Appointment Has Been Added With ID "+_TestAppointment.TestAppointmentID.ToString()+"Successfully\n";
            }
            else return "\nTest Appointment   With ID "+_TestAppointment.TestAppointmentID.ToString()+ " Has Been Updated Successfully\n";

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_TestMode == enTestMode.TakeTest)
            {
                _TestAppointment.RetakeTestApplicationID = -1;
                _TestAppointment.CreatedByUserID = _LocalDrivingLicense.Application.CreatedByUserID;
                _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicense.LocalDrivingLicenseID;
                _TestAppointment.PaidFees = _TestType.Fees;
                _TestAppointment.AppointmentDate = dtDate.Value;
                _TestAppointment.IsLocked = false;
                _TestAppointment.TestTypeID = _TestType.ID;

                    if (_TestAppointment.Save())
                    {
                        MessageBox.Show(ShowProperDoneMessage(), "Done");
                    _TestAppointmentID = _TestAppointment.TestAppointmentID;
                        DataBack?.Invoke(this, _TestAppointmentID);
                        this.Close();
                    }
                    else MessageBox.Show("Failed");


            }
            else 
            {
                clsApplication RetakeApplication = new clsApplication();
                RetakeApplication.ApplicationDate = DateTime.Now;
                RetakeApplication.ApplicationPersonID = _LocalDrivingLicense.Application.ApplicationPersonID;
                RetakeApplication.ApplicationStatus = 1;
                RetakeApplication.LastStatusDate = DateTime.Now;
                RetakeApplication.ApplicationTypeID = 8;
                RetakeApplication.CreatedByUserID = _TestAppointment.CreatedByUserID;
                RetakeApplication.PaiedFees = RetakeApplication.SelectedApplicationType.Fees;
                RetakeApplication.Save();
               _TestAppointment.CreatedByUserID = _LocalDrivingLicense.Application.CreatedByUserID;
               _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicense.LocalDrivingLicenseID;
               _TestAppointment.PaidFees = _TestType.Fees + RetakeApplication.SelectedApplicationType.Fees ;
               _TestAppointment.AppointmentDate = dtDate.Value;
               _TestAppointment.IsLocked = false;
               _TestAppointment.TestTypeID = _TestType.ID;
              
                if (_TestAppointment.Save() )
                {
                    lbRTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                    MessageBox.Show($"\nRetake Test Appointment Has Been Added With ID {_TestAppointment.TestAppointmentID} Successfully\n", "Done");
                    DataBack?.Invoke(this, _TestAppointment.TestAppointmentID);
                    this.Close();
                }
                else MessageBox.Show("Failed");

            }



        }
    }
}

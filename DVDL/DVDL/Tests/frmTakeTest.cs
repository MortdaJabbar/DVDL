using DVDL.Properties;
using DVDLBussinesLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVDL.Tests
{
    public partial class frmTakeTest : Form
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        private enTestType _TestType;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestType theTestType;
        private clsTestAppointment _TestAppointment;
        private clsTest _Test;
        private int _TestID = -1;
        private int _TestAppointmentID = -1;
        private enum enFormMode { Add = 1, Show = 2 }
        private enFormMode _FormMode;
        public frmTakeTest(enTestType testType, clsTestAppointment TestAppointment)
        {
            InitializeComponent();
            _TestType = testType;
            _TestAppointment = TestAppointment;
            _TestAppointmentID = _TestAppointment.TestAppointmentID;
            _FormMode = enFormMode.Add;
           
        }
        public frmTakeTest(enTestType testType, int TestID)
        {
            InitializeComponent();
            _TestType = testType;
            _Test = clsTest.FindTestByTestID(TestID);
            _LocalDrivingLicenseApplicationID = _Test.TestAppointment.LocalDrivingLicenseApplicationID;
            _TestID = TestID;
            _FormMode = enFormMode.Show;

        }
        private void _InitalTakeTestForm()
        {
            switch (_TestType)
            {
                case enTestType.VisionTest:
                    {
                        pbTestImage.Image = Resources.Vision_512;
                        gbTakeTest.Text = "Vision Test";
                    }
                    break;

                case enTestType.WrittenTest:
                    {
                        pbTestImage.Image = Resources.Written_Test_512;
                        gbTakeTest.Text = "Written Test";
                    }
                    break;

                case enTestType.StreetTest:
                    {
                        pbTestImage.Image = Resources.driving_test_512;
                        gbTakeTest.Text = "Street Test";
                    }
                    break;

            }

        }
        private void _PerfomShowMode()
        {
            clsTest test = clsTest.FindTestByTestID(_TestID);
            btnSave.Enabled = false;
            rbPass.Checked = test.TestResult;
            rbFail.Checked = !test.TestResult;
            txtNotes.Enabled = false;
            lbTestID.Text = _TestID.ToString();
            rbPass.Enabled = rbFail.Enabled = false;
            lbResultTest.Visible = true;
            if (rbPass.Checked) { lbResultTest.Text = "Test Passed Successfuly"; }
            else lbResultTest.Text = "Test Failed";
        }
        private void _LoadInitalInfo()
        {
           
               _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
                theTestType = clsTestType.GetTestTypeByID((int)_TestType);
                lbDate.Text =_TestAppointment.AppointmentDate.ToShortDateString();
                lbDrivingClass.Text = _TestAppointment.LDLApplication.LicenseCLass.ClassName;
                lbFees.Text = theTestType.Fees.ToString();
                lbTrial.Text = clsTestAppointment.GetTotalOfFailedTestsForLDLA((int)_TestType, _TestAppointment.LDLApplication.LocalDrivingLicenseID).ToString();
                lbLDLAppID.Text = _TestAppointment.LDLApplication.LocalDrivingLicenseID.ToString();
                lbName.Text = _TestAppointment.LDLApplication.Application.SelectedPerson.FullName;
            if (_FormMode == enFormMode.Show)
            {
                _PerfomShowMode();
            }

        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _InitalTakeTestForm();
            _LoadInitalInfo();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }                 
        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTest Test = new clsTest();
            Test.TestAppointmentID = _TestAppointmentID;
            Test.CreatedByUserID = _TestAppointment.CreatedByUserID;
            Test.TestResult = rbPass.Checked;
            if (txtNotes.Text.Trim() == "") { Test.Notes = "No Notes"; }
            else Test.Notes = txtNotes.Text;

            if (Test.Save()) 
            {
                lbTestID.Text = Test.TestID.ToString();
                MessageBox.Show($"Test Has Been Taken With ID {Test.TestID}");
                _TestAppointment.IsLocked = true;
                _TestAppointment.Save();
                 
                this.Close();
               

            }
            else { MessageBox.Show($"Failed To Take Test "); this.Close(); }


        }
    
    
    }
}

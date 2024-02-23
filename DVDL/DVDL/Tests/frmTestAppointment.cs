using DVDL.Properties;
using DVDLBussinesLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL.Tests
{
    public partial class frmTestAppointment : Form
    {

        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        private enTestType _formTestType;
        public enum enFormMode { Add = 1, Update = 2 }
        public enFormMode FormMode;
        private int _LDLAppID = -1;
        private clsLocalDrivingLicense _LDLApplication;
        public frmTestAppointment(enTestType TestType)
        {
            InitializeComponent();
            _formTestType = TestType;
            FormMode = enFormMode.Add;
        }
        public frmTestAppointment(int LocalDrivingLicenseApplicationID, enTestType TestType)
        {
            InitializeComponent();
            _LDLAppID = LocalDrivingLicenseApplicationID;
            _formTestType = TestType;
             FormMode = enFormMode.Update;
            _LDLApplication = clsLocalDrivingLicense.FindLocalDrivingLicense(_LDLAppID);
        }
        private void _InitalTestAppointment()
        {
            switch (_formTestType)
            {
                case enTestType.VisionTest:

                    {
                        pbTestPicture.Image = Resources.Vision_512;
                        lbTestAppointmentTitle.Text = "Vision Test Appointment";

                    }
                    break;

                case enTestType.WrittenTest:

                    {
                        pbTestPicture.Image = Resources.Written_Test_512;
                        lbTestAppointmentTitle.Text = "Written Test Appointment";

                    }
                    break;

                case enTestType.StreetTest:
                    {
                        pbTestPicture.Image = Resources.driving_test_512;
                        lbTestAppointmentTitle.Text = "Street Test Appointment";

                    }
                    break;
            }

        }
        private void frmVisionTestAppointment_Load(object sender, EventArgs e)
        {
            _InitalTestAppointment();
            ctrLocalDrivingLicenseCard1.LoadLocalDrivingLicenseInfo(_LDLAppID);
            LoadAllAppointments();

        }
        private void pbAddNewAppointment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.DoesApplicationHasActiveAppointment(_LDLAppID, (int)_formTestType))
            {
                MessageBox.Show("This Person Has An Active Appointment So We Can't Give You Another Appointment ,Please Finsh Your Test  Appointment", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsTestAppointment.IsPersonHasPassedTheTest(_LDLAppID, (int)_formTestType))
            {
                MessageBox.Show("This Person Has Already Passed The Test  So We Can't Give You Another Appointment ", "Finshied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (clsTestAppointment.GetTotalOfFailedTestsForLDLA((int)_formTestType, _LDLAppID) >= 1) 
            {
                frmSechdualTest frm = new frmSechdualTest(_LDLApplication, (frmSechdualTest.enTestType)_formTestType,frmSechdualTest.enTestMode.RetakeTest);
                frm.ShowDialog();
                LoadAllAppointments();
            }
            else 
            {
                frmSechdualTest frm = new frmSechdualTest(_LDLApplication, (frmSechdualTest.enTestType)_formTestType, frmSechdualTest.enTestMode.TakeTest);
                frm.ShowDialog();
                LoadAllAppointments();
            }

        
        }
        private void LoadAllAppointments()
        {
            DataTable AppointmentsList = clsTestAppointment.GetAllAppointmentsForLocalDrivingLicense(_LDLAppID, (int)_formTestType);
            dgvAppointments.DataSource = AppointmentsList;
            lbTotalRecords.Text = dgvAppointments.RowCount.ToString();
            ctrLocalDrivingLicenseCard1.RefershPassedTest();
            
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells["AppointmentID"].Value;
            clsTestAppointment TestAppointment = clsTestAppointment.FindTestAppointmentByID(TestAppointmentID);
           
            
                frmSechdualTest frm = new frmSechdualTest(TestAppointment, (frmSechdualTest.enTestType)TestAppointment.TestTypeID, frmSechdualTest.enTestMode.RetakeTest);
                frm.ShowDialog();
            frmVisionTestAppointment_Load(null, null);



        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells["AppointmentID"].Value;
            clsTestAppointment TestAppointment = clsTestAppointment.FindTestAppointmentByID(TestAppointmentID);
            frmTakeTest frm = new frmTakeTest( (frmTakeTest.enTestType)TestAppointment.TestTypeID, TestAppointment);
            frm.ShowDialog();
            LoadAllAppointments();
        }

    
    }
}

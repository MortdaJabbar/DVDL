using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDL.Tests;
using DVDLBussinesLogicTier;
using Microsoft.VisualBasic.Devices;
using static System.Net.Mime.MediaTypeNames;
namespace DVDL.Applications.LocalLicense
{
    public partial class frmMangeLocalDrivingLicensesApplication : Form
    {
        private int _LicenseID = -1;
        private DataTable _AllLDL = clsLocalDrivingLicense.GetAllLDLApplicationsFormated();
        public frmMangeLocalDrivingLicensesApplication()
        {
            InitializeComponent();
        }
        private void _LoadLocalDrivingLicensesApplication(DataTable LDLApplciation)
        {


            dgvLocalDrivingLicenses.DataSource = LDLApplciation;

            dgvLocalDrivingLicenses.Columns[0].HeaderText = "LDLApplicationID";
            dgvLocalDrivingLicenses.Columns[1].HeaderText = "Driving Class";
            dgvLocalDrivingLicenses.Columns[6].HeaderText = "Status";



            lbTotalRecords.Text = dgvLocalDrivingLicenses.RowCount.ToString();
        }
        private void frmMangeLocalDrivingLicensesApplication_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            _LoadLocalDrivingLicensesApplication(_AllLDL);

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _SearchLocalDrivingLicnese()
        {
            DataTable AllLDL = clsLocalDrivingLicense.GetAllLDLApplicationsFormated();
            string FilterValue = txtFilter.Text;
            switch (cbFilter.SelectedItem.ToString())
            {
                case "LDLApplicationID":
                    {
                        if (AllLDL.Select($"LocalDrivingLicenseApplicationID = {FilterValue}").Length > 0)
                        {
                            AllLDL = AllLDL.Select($"LocalDrivingLicenseApplicationID = {FilterValue}").CopyToDataTable();
                        }
                        else { txtFilter.Clear(); MessageBox.Show($"Sorry, No  Local Driving License With ID: {FilterValue}"); AllLDL = _AllLDL; }
                    }
                    break;

                case "NationalNo":
                    {

                        if (AllLDL.Select($"NationalNo = '{FilterValue}'").Length > 0)
                        {

                            AllLDL = AllLDL.Select($"NationalNo = '{FilterValue}' ").CopyToDataTable();
                        }
                        else { txtFilter.Clear(); MessageBox.Show($"Sorry, No Local Driving License With NationalNo: {FilterValue}"); AllLDL = _AllLDL; }

                    }
                    break;

                default: AllLDL = _AllLDL; break;
            }


            _LoadLocalDrivingLicensesApplication(AllLDL);
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == "None") { txtFilter.Visible = false; }
            else txtFilter.Visible = true;
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem == "LDLApplicationID") { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }


        }
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter) { _SearchLocalDrivingLicnese(); }
        }
        private void pbAddNewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicense frm = new frmAddUpdateLocalDrivingLicense();
            frm.ShowDialog();
        }
        private void sechdualVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value;
            frmTestAppointment frm = new frmTestAppointment(LDLAppID, frmTestAppointment.enTestType.VisionTest);
            frm.ShowDialog();
            _AllLDL = clsLocalDrivingLicense.GetAllLDLApplicationsFormated();
            _LoadLocalDrivingLicensesApplication(_AllLDL);
        }
        private void sechdualWritingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value;
            frmTestAppointment frm = new frmTestAppointment(LDLAppID, frmTestAppointment.enTestType.WrittenTest);
            frm.ShowDialog();
            _AllLDL = clsLocalDrivingLicense.GetAllLDLApplicationsFormated();
            _LoadLocalDrivingLicensesApplication(_AllLDL);
        }
        private void _DisableTakenTests(int PassedTests)
        {

            switch (PassedTests)
            {
                case 0:
                    {
                        SechdualTestChoice.Enabled = true;
                        VisionTestChoice.Enabled = true;
                        WrittenTestChoice.Enabled = false;
                        StreetTestChoice.Enabled = false;
                        issueDrivingLicenseFirstTimeChoice.Enabled = false;

                    }
                    break;

                case 1:
                    {
                        SechdualTestChoice.Enabled = true;
                        VisionTestChoice.Enabled = false;
                        WrittenTestChoice.Enabled = true;
                        StreetTestChoice.Enabled = false;
                        issueDrivingLicenseFirstTimeChoice.Enabled = false;
                    }
                    break;
                case 2:
                    {
                        SechdualTestChoice.Enabled = true;
                        VisionTestChoice.Enabled = false;
                        WrittenTestChoice.Enabled = false;
                        StreetTestChoice.Enabled = true;
                        issueDrivingLicenseFirstTimeChoice.Enabled = false;
                    }
                    break;

                case 3:
                    {
                        VisionTestChoice.Enabled = false;
                        WrittenTestChoice.Enabled = false;
                        StreetTestChoice.Enabled = false;
                        SechdualTestChoice.Enabled = false;
                        issueDrivingLicenseFirstTimeChoice.Enabled = true;
                    }
                    break;
            }

        }
        private void StreetTestChoice_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value;
            frmTestAppointment frm = new frmTestAppointment(LDLAppID, frmTestAppointment.enTestType.StreetTest);
            frm.ShowDialog();
            _AllLDL = clsLocalDrivingLicense.GetAllLDLApplicationsFormated();
            _LoadLocalDrivingLicensesApplication(_AllLDL);

        }
        private void _DsableOptionsForCompletedOrCanceledApplication(string StatusText) 
        {
            switch (StatusText) 
            {
                case "New": 
                    {
                        EditApplicationChoice.Enabled   = true;
                        CancelApplicationChoice.Enabled = true;
                        DeleteApplicationChoice.Enabled = true;
                        showDrivingLiceneInfoChoice.Enabled = false;
                         
                        ShowLicenseHistoryChoice.Enabled = false;

                    }
                  break;
                case "Canceled":
                    {
                        EditApplicationChoice.Enabled = false;
                        CancelApplicationChoice.Enabled = false;
                        DeleteApplicationChoice.Enabled = false;
                        SechdualTestChoice.Enabled = false;
                        showDrivingLiceneInfoChoice.Enabled = false;
                        
                        ShowLicenseHistoryChoice.Enabled = false;

                    }
                    break;
                case "Completed":
                    {
                        EditApplicationChoice.Enabled = false;
                        CancelApplicationChoice.Enabled = false;
                        DeleteApplicationChoice.Enabled = false;
                        SechdualTestChoice.Enabled = false;
                        showDrivingLiceneInfoChoice.Enabled = true;
                        issueDrivingLicenseFirstTimeChoice.Enabled = false;
                        ShowLicenseHistoryChoice.Enabled = true;

                    }
                    break;

            }
        }
        private void cmsOperationOnLDLA_Opening(object sender, CancelEventArgs e)
        {

            int PassedTests = (int)dgvLocalDrivingLicenses.CurrentRow.Cells["PassedTests"].Value;
            string ApplicationStatus = (string)dgvLocalDrivingLicenses.CurrentRow.Cells["StatusText"].Value;
            _DisableTakenTests(PassedTests);
            _DsableOptionsForCompletedOrCanceledApplication(ApplicationStatus);
            
        }
        private void LDLApplicationInfoChoice_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;
            frmShowDrivingLicenseApplicationInfo frm = new frmShowDrivingLicenseApplicationInfo(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
        }
        private void EditApplicationChoice_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;
            frmAddUpdateLocalDrivingLicense frm = new frmAddUpdateLocalDrivingLicense(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            _AllLDL = clsLocalDrivingLicense.GetAllLDLApplicationsFormated();
            _LoadLocalDrivingLicensesApplication(_AllLDL);
        }
        private void DeleteApplicationChoice_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;
            if (MessageBox.Show("Do You Want To Delete This Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                if (clsLocalDrivingLicense.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID)) 
                {
                    MessageBox.Show("Application Was Deleted Successfuly","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _AllLDL = clsLocalDrivingLicense.GetAllLDLApplicationsFormated();
                    _LoadLocalDrivingLicensesApplication(_AllLDL);

                }
                else { MessageBox.Show("Falied To Deleted The Application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        }
        private void CancelApplicationChoice_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;
            clsLocalDrivingLicense localdrivinglicesne = clsLocalDrivingLicense.FindLocalDrivingLicense(LocalDrivingLicenseApplicationID);
            if (MessageBox.Show("Do You Want To Cancel This Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                localdrivinglicesne.Application.LastStatusDate = DateTime.Now;
                localdrivinglicesne.Application.ApplicationStatus = 2;
                if (localdrivinglicesne.Application.Save())
                {
                    MessageBox.Show("Application Was Canceled Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _AllLDL = clsLocalDrivingLicense.GetAllLDLApplicationsFormated();
                    _LoadLocalDrivingLicensesApplication(_AllLDL);

                }
                else { MessageBox.Show("Falied To Canceled The Application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        }
        private void issueDrivingLicenseFirstTimeChoice_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;
            frmIssueNewDrivingLicense frm = new frmIssueNewDrivingLicense(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            _AllLDL = clsLocalDrivingLicense.GetAllLDLApplicationsFormated();
            _LoadLocalDrivingLicensesApplication(_AllLDL);

        }
        private void showDrivingLiceneInfoChoice_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;
            clsLocalDrivingLicense ldla = clsLocalDrivingLicense.FindLocalDrivingLicense(LocalDrivingLicenseApplicationID);
            _LicenseID = clsLicense.GetLicenseIDByApplication(ldla.LicenseClassID, ldla.ApplicationID);
           
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }
        private void ShowLicenseHistoryChoice_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenses.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;
            int PersonID = clsLocalDrivingLicense.FindLocalDrivingLicense(LocalDrivingLicenseApplicationID).Application.ApplicationPersonID;
            frmShowLicenseHistory frm = new frmShowLicenseHistory(PersonID);
            frm.ShowDialog();
        }
    
       private void TakeTheReturnedLicenseID(object sender,int LicenseID) 
        {
            MessageBox.Show(LicenseID.ToString());
            _LicenseID = LicenseID; 
        }
    
    }
}

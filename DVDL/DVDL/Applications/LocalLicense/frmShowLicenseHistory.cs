using DVDL.Applications.LocalLicense;
using DVDL.InternationalLicense;
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

namespace DVDL
{
    public partial class frmShowLicenseHistory : Form
    {
        int _PersonID = -1;
        
        public frmShowLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        private void _FillLicenseTable()
        {
            DataTable dt = clsLicense.GetAllLicenseForPerson(_PersonID);
           
             dgvLicenses.DataSource = dt; 
           
        }
        private void _FillInternationalLicenseTable()
        {
            DataTable dt = clsInternationalLicense.GetAllInternationalLicensesForPerson(_PersonID);
            
             dgvInternationalLicense.DataSource = dt; 
        
        }
        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            if (!clsPerson.isPersonExsist(_PersonID)) { MessageBox.Show($"No Person With PersonID {_PersonID}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            ctrPersonInfoWithFilter1.FillPersonInfo(_PersonID);
            ctrPersonInfoWithFilter1.GbFilterEnable = false;
            ctrPersonInfoWithFilter1.FilterValue = _PersonID.ToString();
           
            if (!clsDriver.IsDriverExisitByPersonID(_PersonID)) { MessageBox.Show("Person is not likned with any Driver in the system","Not A Driver",MessageBoxButtons.OK,MessageBoxIcon.Error);return; }
           

            _FillLicenseTable();
            _FillInternationalLicenseTable();
        }
        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLicenses.CurrentRow.Cells["LicenseID"].Value;
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }
        private void showInternaionalLiceseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternationalLicense.CurrentRow.Cells["InternationalLicenseID"].Value;
            frmShowInternationalLicense frm = new frmShowInternationalLicense(InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}

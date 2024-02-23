using DVDL.Applications.LocalLicense;
using DVDL.DetainAndRelease;
using DVDL.Pepole;
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
    public partial class frmManageDetainAndReleaseLicense : Form
    {
        private DataTable _Detained = clsDetainLicense.GetAllDetainedLicenses();
        public frmManageDetainAndReleaseLicense()
        {
            InitializeComponent();
        }
        private void _LoadDetainedLicenseInDataGridView(DataTable DetainedLicneses)
        {
            dgvDetainedLicenses.DataSource = DetainedLicneses;
            lbTotalRecords.Text = dgvDetainedLicenses.RowCount.ToString();
        }
        private void frmManageDetainAndReleaseLicense_Load(object sender, EventArgs e)
        {

            cbFilter.SelectedIndex = 0;
            txtFilter.Visible = false;
            _LoadDetainedLicenseInDataGridView(_Detained);
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == "None") { txtFilter.Visible = false; }
            else txtFilter.Visible = true;
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text.Trim() == "LicenseID" || cbFilter.Text.Trim() == "DetainID") { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }
        }
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { _FilterTables(txtFilter.Text); }
        }
        private void _FilterTables(string FilterValue)
        {
            DataTable DetianedLicense = clsDetainLicense.GetAllDetainedLicenses();
            if (FilterValue.Trim() != "")
            {
                switch (cbFilter.SelectedItem.ToString())
                {
                    case "DetainID":
                        {
                            if (DetianedLicense.Select($"DetainID = {FilterValue}").Length > 0)
                            {
                                DetianedLicense = DetianedLicense.Select($"DetainID = {FilterValue}").CopyToDataTable();
                            }
                            else { MessageBox.Show($"Sorry, No License With DetainID: {FilterValue}"); DetianedLicense = _Detained; }
                        }
                        break;

                    case "NationalNo":
                        {

                            if (DetianedLicense.Select($"NationalNo like '%{FilterValue}%'").Length > 0)
                            {

                                DetianedLicense = DetianedLicense.Select($"NationalNo like '%{FilterValue}%' ").CopyToDataTable();
                            }
                            else { MessageBox.Show($"Sorry, No License With NationalNo: {FilterValue}"); DetianedLicense = _Detained; }

                        }
                        break;

                    case "LicenseID":
                        {

                            if (DetianedLicense.Select($"LicenseID = {FilterValue}").Length > 0)
                            {

                                DetianedLicense = DetianedLicense.Select($"LicenseID ={FilterValue}").CopyToDataTable();
                            }
                            else { MessageBox.Show($"Sorry, No License With LicenseID: {FilterValue}"); DetianedLicense = _Detained; }

                        }
                        break;

                    default:
                        DetianedLicense = _Detained;
                        break;

                }
            }

            _LoadDetainedLicenseInDataGridView(DetianedLicense);
        }

        private void showPersonDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = dgvDetainedLicenses.CurrentRow.Cells["NationalNo"].Value.ToString();
            int PersonID = clsPerson.FindPersonByNationalNo(NationalNo).PersonID;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void showPersonHistoryLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = dgvDetainedLicenses.CurrentRow.Cells["NationalNo"].Value.ToString();
            int PersonID = clsPerson.FindPersonByNationalNo(NationalNo).PersonID;
            frmShowLicenseHistory frm = new frmShowLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void pbDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();

            frm.ShowDialog();
            _Detained = clsDetainLicense.GetAllDetainedLicenses();
            _LoadDetainedLicenseInDataGridView(_Detained);
        }

        private void pbRelease_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense();
            frm.ShowDialog();
            _Detained = clsDetainLicense.GetAllDetainedLicenses();
            _LoadDetainedLicenseInDataGridView(_Detained);
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;
            frmDetainLicense frm = new frmDetainLicense(LicenseID);
            frm.ShowDialog();
            _Detained = clsDetainLicense.GetAllDetainedLicenses();
            _LoadDetainedLicenseInDataGridView(_Detained);
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;
            frmReleaseLicense frm = new frmReleaseLicense(LicenseID);
            frm.ShowDialog();
            _Detained = clsDetainLicense.GetAllDetainedLicenses();
            _LoadDetainedLicenseInDataGridView(_Detained);
        }
    }

}


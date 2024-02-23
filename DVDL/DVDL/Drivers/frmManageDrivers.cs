using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDL.Pepole;
using DVDLBussinesLogicTier;
namespace DVDL.Drivers
{
    public partial class frmManageDrivers : Form
    {
        private DataTable _Drivers = clsDriver.GetAllDriversFormated();
        public frmManageDrivers()
        {
            InitializeComponent();
        }
        private void _LoadDriversInDataGridView(DataTable Drivers)
        {
            dgvDrivers.DataSource = Drivers;
            dgvDrivers.Columns["CreatedDate"].HeaderText = "Date";
            lbTotalRecords.Text = dgvDrivers.Rows.Count.ToString();
        }
        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            _LoadDriversInDataGridView(_Drivers);
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == "None") { txtFilter.Visible = false; }
            else txtFilter.Visible = true;
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem == "DriverID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            }
        }
        private void _FilterDataGridView()
        {
            DataTable Drivers = clsDriver.GetAllDriversFormated();
            string FilterValue = txtFilter.Text;
            if (FilterValue.Trim() == "") { _LoadDriversInDataGridView(Drivers); }
            switch (cbFilter.SelectedItem.ToString())
            {
                case "DriverID":
                    {
                        if (Drivers.Select($"DriverID = {FilterValue}").Length > 0)
                        {
                            Drivers = Drivers.Select($"DriverID = {FilterValue}").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With DriverID: {FilterValue}"); Drivers = _Drivers; txtFilter.Clear(); }
                        _LoadDriversInDataGridView(Drivers);
                    }
                    break;

                case "NationalNo":
                    {

                        if (Drivers.Select($"NationalNo like '{FilterValue}'").Length > 0)
                        {
                            Drivers = Drivers.Select($"NationalNo = '{FilterValue}' ").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With NationalNo: {FilterValue}"); Drivers = _Drivers; txtFilter.Clear(); }
                        _LoadDriversInDataGridView(Drivers);
                    }
                    break;
            }
        }
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _FilterDataGridView();
            }
        }

        private void showPersonDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells["PersonID"].Value;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;
            frmShowLicenseHistory frm = new frmShowLicenseHistory(PersonID);
            frm.ShowDialog();
        }
    }
}

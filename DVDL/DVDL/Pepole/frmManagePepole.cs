using DVDLBussinesLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL.Pepole
{
    public partial class frmManagePepole : Form
    {
        public frmManagePepole()
        {
            InitializeComponent();

        }

        private DataTable _AllPeople = clsPerson.GetAllPepole();
        private string _GetMaleOrFemaleString(byte gender)
        {

            return (gender == 0) ? "Male" : "Female";
        }

        private void _FillGridTableWithData(ref DataTable People)
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(People.Rows.Count);
            int RowCounter = 0;
            foreach (DataRow Person in People.Rows)
            {
                dataGridView1.Rows[RowCounter].Cells["PersonID"].Value = Person["PersonID"];
                dataGridView1.Rows[RowCounter].Cells["NationalNo"].Value = Person["NationalNo"];
                dataGridView1.Rows[RowCounter].Cells["FirstName"].Value = Person["FirstName"];
                dataGridView1.Rows[RowCounter].Cells["SecondName"].Value = Person["SecondName"];
                dataGridView1.Rows[RowCounter].Cells["ThirdName"].Value = Person["ThirdName"];
                dataGridView1.Rows[RowCounter].Cells["LastName"].Value = Person["LastName"];
                dataGridView1.Rows[RowCounter].Cells["Email"].Value = Person["Email"];
                dataGridView1.Rows[RowCounter].Cells["Phone"].Value = Person["Phone"];
                dataGridView1.Rows[RowCounter].Cells["Gender"].Value = _GetMaleOrFemaleString((byte)Person["Gender"]);
                dataGridView1.Rows[RowCounter].Cells["DateOfBirth"].Value = ((DateTime)Person["DateOfBirth"]).ToShortDateString();
                dataGridView1.Rows[RowCounter].Cells["Nationality"].Value = clsCountry.GetCountryByID((int)Person["NationalityCountryID"]).CountryName;
                RowCounter++;
            }
            lbTotalRecords.Text = dataGridView1.RowCount.ToString();

        }
        private void _FilterTables(string FilterValue)
        {
            DataTable People = clsPerson.GetAllPepole();

            switch (cbFilters.SelectedItem.ToString())
            {
                case "PersonID":
                    {
                        if (People.Select($"PersonID = {FilterValue}").Length > 0)
                        {
                            People = People.Select($"PersonID = {FilterValue}").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With PersonID: {FilterValue}"); People = _AllPeople; }
                    }
                    break;

                case "NationalNo":
                    {

                        if (People.Select($"NationalNo = '{FilterValue}'").Length > 0)
                        {

                            People = People.Select($"NationalNo = '{FilterValue}' ").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With NationalNo: {FilterValue}"); People = _AllPeople; }

                    }
                    break;

                case "FirstName":
                    {

                        if (People.Select($"FirstName like '%{FilterValue}%'").Length > 0)
                        {

                            People = People.Select($"FirstName like '%{FilterValue}%'").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With FirstName: {FilterValue}"); People = _AllPeople; }

                    }

                    break;

                case "LastName":
                    {

                        if (People.Select($"LastName = '%{FilterValue}%'").Length > 0)
                        {

                            People = People.Select($"LastName = '%{FilterValue}%'").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With LastName: {FilterValue}"); People = _AllPeople; }

                    }

                    break;

                case "SecondName":
                    {

                        if (People.Select($"SecondName = '%{FilterValue}%'").Length > 0)
                        {

                            People = People.Select($"SecondName = '%{FilterValue}%'").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With SecondName: {FilterValue}"); People = _AllPeople; }

                    }

                    break;

                case "Gender":
                    {

                        if (People.Select($"Gender ={((FilterValue == "Male") ? 0 : 1)}").Length > 0)
                        {

                            People = People.Select($"Gender ={((FilterValue == "Male") ? 0 : 1)}").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With Gender: {FilterValue}"); People = _AllPeople; }

                    }

                    break;


                case "Email":
                    {

                        if (People.Select($"Email ='{FilterValue}' ").Length > 0)
                        {

                            People = People.Select($"Email ='{FilterValue}' ").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With Email : {FilterValue}"); People = _AllPeople; }

                    }

                    break;

                case "Phone":
                    {

                        if (People.Select($"Phone ='{FilterValue}'").Length > 0)
                        {

                            People = People.Select($"Phone ='{FilterValue}'").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With Phone : {FilterValue}"); People = _AllPeople; }

                    }

                    break;


                case "Nationality":
                    {
                        if (People.Select($"NationalityCountryID ='{clsCountry.GetCountryIDByCountryName(FilterValue)}'").Length > 0)
                        {

                            People = People.Select($"NationalityCountryID ='{clsCountry.GetCountryIDByCountryName(FilterValue)}'").CopyToDataTable();
                        }
                        else { MessageBox.Show($"Sorry, No Person With Nationality : {FilterValue}"); People = _AllPeople; }
                    }
                    break;

                default:
                    People = _AllPeople;
                    break;
            }

            _FillGridTableWithData(ref People);
        }
        private void frmManagePepole_Load(object sender, EventArgs e)
        {
            _FillGridTableWithData(ref _AllPeople);
            cbFilters.SelectedIndex = 0;

        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && (cbFilters.SelectedItem == "PersonID");
        }
        private void txtFilter_Leave(object sender, EventArgs e)
        {

            if (txtFilter.Text.Trim() != "")
            {
                _FilterTables(txtFilter.Text.Trim());
            }
            else _FillGridTableWithData(ref _AllPeople);

        }
        private void _RefreshPeopleList()
        {
            DataTable People = clsPerson.GetAllPepole();
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(People.Rows.Count);
            int RowCounter = 0;
            foreach (DataRow Person in People.Rows)
            {
                dataGridView1.Rows[RowCounter].Cells["PersonID"].Value = Person["PersonID"];
                dataGridView1.Rows[RowCounter].Cells["NationalNo"].Value = Person["NationalNo"];
                dataGridView1.Rows[RowCounter].Cells["FirstName"].Value = Person["FirstName"];
                dataGridView1.Rows[RowCounter].Cells["SecondName"].Value = Person["SecondName"];
                dataGridView1.Rows[RowCounter].Cells["ThirdName"].Value = Person["ThirdName"];
                dataGridView1.Rows[RowCounter].Cells["LastName"].Value = Person["LastName"];
                dataGridView1.Rows[RowCounter].Cells["Email"].Value = Person["Email"];
                dataGridView1.Rows[RowCounter].Cells["Phone"].Value = Person["Phone"];
                dataGridView1.Rows[RowCounter].Cells["Gender"].Value = _GetMaleOrFemaleString((byte)Person["Gender"]);
                dataGridView1.Rows[RowCounter].Cells["DateOfBirth"].Value = ((DateTime)Person["DateOfBirth"]).ToShortDateString();
                dataGridView1.Rows[RowCounter].Cells["Nationality"].Value = clsCountry.GetCountryByID((int)Person["NationalityCountryID"]).CountryName;
                RowCounter++;
            }
            lbTotalRecords.Text = dataGridView1.RowCount.ToString();
        }
        private void pbAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson newForm = new frmAddUpdatePerson(-1);

            newForm.ShowDialog();
            _RefreshPeopleList();

        }
        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            frmShowPersonInfo ShowPersonInfo = new frmShowPersonInfo(PersonID);
            ShowPersonInfo.ShowDialog();
            _RefreshPeopleList();

        }
        private void editPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            frmAddUpdatePerson EditPersonForm = new frmAddUpdatePerson(PersonID);
            EditPersonForm.ShowDialog();
            _RefreshPeopleList();
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson EditPersonForm = new frmAddUpdatePerson(-1);
            EditPersonForm.ShowDialog();
            _RefreshPeopleList();
        }
        private void deletePersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            DialogResult Decsion = MessageBox.Show("Do You Want to Delete This Person", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;
            if (Decsion == DialogResult.Yes)
            {
                bool Deleted = clsPerson.DeletePerson(PersonID);
                if (!Deleted) { MessageBox.Show($"Person With ID ({PersonID}) Was not Deleted Because it has other dependandcies in the system"); return; }
                MessageBox.Show("Person Was Deleted Sucssefuly");
                _RefreshPeopleList();
            }
        }
        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will Add This Feature Soon...!");
        }
        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will Add This Feature Soon...!");
        }
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "None")
            {
                txtFilter.Visible = false;
            }
            else txtFilter.Visible = true;
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmShowLicenseHistory frm = new frmShowLicenseHistory(PersonID);
            frm.ShowDialog();
        }
    }


}


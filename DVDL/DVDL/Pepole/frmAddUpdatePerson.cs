using DVDL.Properties;
using DVDLBussinesLogicTier;
using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL.Pepole
{
    public partial class frmAddUpdatePerson : Form
    {

        public delegate void DataBackHandler(object sender, int PersonID);
        
        public event DataBackHandler DataBack;
        
        private clsPerson _Person;
        
        private int _PersonID;
        private enum enMode { AddNewPerson = 0, UpdatePerson = 1 };

        private enMode FormMode;
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _LoadCountriesIntoComboBox();
            _PersonID = PersonID;
            if (_PersonID <= 0) { _Person = new clsPerson(); FormMode = enMode.AddNewPerson; }
            else { FormMode = enMode.UpdatePerson; _Person = clsPerson.FindPersonByID(_PersonID); };


        }
        private void _frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _LoadDefaultInfo();

            if (FormMode == enMode.UpdatePerson)
            {
                _LoadPersonDetailsInForm();
            }
        }
        private void _LoadPersonDetailsInForm()
        {
            if (_Person != null)
            {
                lbPersonID.Text = _Person.PersonID.ToString();
                lbTitle.Text = "Update Person Info";
                txtFirstName.Text = _Person.FirstName;
                txtSecondName.Text = _Person.SecondName;

                if (_Person.ThirdName.Trim() != "")
                {
                    txtThirdName.Text = _Person.ThirdName;
                }
                else { txtThirdName.Text = string.Empty; }

                txtFourthName.Text = _Person.LastName;
                dateTimePicker1.Value = _Person.BirthDate;
                txtPhone.Text = _Person.Phone;

                if (_Person.Email.Trim() != "")
                {
                    txtEmail.Text = _Person.Email;
                }
                else { txtEmail.Text = string.Empty; }


                txtAddress.Text = _Person.Address;
                txtNationalNo.Text = _Person.NationalNumber;
                cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);


                if (_Person.Gender == 1) { rbFemale.Checked = true; }
                else rbMale.Checked = true;

                if (_Person.ImagePath.Trim() != "")
                {

                    PersonImage.ImageLocation = _Person.ImagePath;
                    llRemoveImage.Visible = true;
                }
                else { _LoadDefaultPersonImage(); }

            }
        }
        private void _LoadCountriesIntoComboBox()
        {
            DataTable Countries = clsCountry.GetAllCountries();
            foreach (DataRow country in Countries.Rows) { cbCountry.Items.Add(country["CountryName"]); }

        }
        private void _LoadDefaultPersonImage()
        {

            if (PersonImage.ImageLocation == null || PersonImage.ImageLocation == "")
            {
                if (rbMale.Checked) PersonImage.Image = Resources.Male_512;
                else PersonImage.Image = Resources.Female_512;

            }
        }
        private void _LoadDefaultInfo()
        {
            lbPersonID.Text = "N/A";
            lbTitle.Text = "Add New Person";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtFourthName.Text = "";
            txtPhone.Text = "";
            txtNationalNo.Text = "";
            cbCountry.SelectedIndex = cbCountry.FindString("iraq");
            rbMale.Checked = true;
            PersonImage.ImageLocation = "";
            PersonImage.Image = Resources.Male_512;
            llRemoveImage.Visible = false;
        }
        private void _rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonImage.ImageLocation == null || PersonImage.ImageLocation == "")
            {
                if (rbMale.Checked) PersonImage.Image = Resources.Male_512;
                else PersonImage.Image = Resources.Female_512;
            }
        }
        private void _rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonImage.ImageLocation == null || PersonImage.ImageLocation == "")
            {
                if (rbFemale.Checked) PersonImage.Image = Resources.Female_512;
                else PersonImage.Image = Resources.Male_512;
            }
        }
        private void _llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Images |*.JPEG;*.png;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                PersonImage.Load((string)openFileDialog1.FileName);
                // PersonImage.Image = Image.FromStream(fs);
                llRemoveImage.Visible = true;

            }






        }
        private void _llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            PersonImage.ImageLocation = null;
            _LoadDefaultPersonImage();
            llRemoveImage.Visible = false;
        }
        private bool _HandlePersonImage()
        {
            if (PersonImage.ImageLocation != _Person.ImagePath)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any
                    try
                    {

                        File.Delete(_Person.ImagePath);
                        _Person.ImagePath = "";

                    }
                    catch (IOException e)
                    {
                        MessageBox.Show($"Problem: {e.Message}");
                        // We could not delete the file.
                        //log it later   
                    }
                }
                if (PersonImage.ImageLocation != null)
                {
                    string Des = @"C:\DVLD-People-Images\" + $"{Guid.NewGuid()}.png";
                    File.Copy(PersonImage.ImageLocation, Des);
                    PersonImage.ImageLocation = Des;
                    return true;
                }

                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                }

            }

            return true;

        }
        private void _EmptyTextBoxValidation(object sender, CancelEventArgs E)
        {
            TextBox Temp = ((TextBox)sender);

            if (Temp.Text.Trim() == "")
            {

                E.Cancel = true;
                errorProvider1.SetError(Temp, Temp.Tag.ToString() + " is Requried");
                Temp.Focus();


            }
            else
            {
                errorProvider1.SetError(Temp, null);

            }



        }
        private void _txtNationalNoValidation(object sender, CancelEventArgs E)
        {

            if (txtNationalNo.Text.Trim() == "")
            {

                E.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "NationalNo is Requried");
                txtNationalNo.Focus();

            }

            else if (FormMode == enMode.UpdatePerson && txtNationalNo.Text != _Person.NationalNumber)
            {


                if (clsPerson.isPersonExsist(txtNationalNo.Text))
                {
                    E.Cancel = true;
                    errorProvider1.SetError(txtNationalNo, "This NationalNo Belongs To Another Person");
                    txtNationalNo.Focus();
                }
                else { errorProvider1.SetError(txtNationalNo, null); }

            }
            else if (FormMode == enMode.AddNewPerson)
            {
                if (clsPerson.isPersonExsist(txtNationalNo.Text))
                {
                    E.Cancel = true;
                    errorProvider1.SetError(txtNationalNo, "This NationalNo Belongs To Another Person");
                    txtNationalNo.Focus();
                }
                else { errorProvider1.SetError(txtNationalNo, null); }
            }



        }
        private void _txtPhoneValidation(object sender, CancelEventArgs E)
        {

            if (txtPhone.Text.Trim() == "" || !clsValidation.ValidateNumber(txtPhone.Text) || txtPhone.Text.Length != 6)
            {

                E.Cancel = true;
                errorProvider1.SetError(txtPhone, "Please Enter A Phone Number Consist of 9 digits numbers only");
                txtPhone.Focus();

            }
            else { errorProvider1.SetError(txtPhone, null); }

        }
        private void _txtEmailValidation(object sender, CancelEventArgs E)
        {

            if (txtEmail.Text.Trim() == "")
            {

                errorProvider1.SetError(txtEmail, null);

                return;
            }
            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                E.Cancel = true;

                errorProvider1.SetError(txtEmail, "Please Enter A Valid Email");
                txtEmail.Focus();

            }
            else { errorProvider1.SetError(txtEmail, null); }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren()) { MessageBox.Show("Validateion Fail"); return; }
            if (!_HandlePersonImage()) { MessageBox.Show("Image Fail"); return; }

            _Person.NationalNumber = txtNationalNo.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtFourthName.Text;
            _Person.BirthDate = dateTimePicker1.Value;
            _Person.Gender = (rbMale.Checked) ? (byte)0 : (byte)1;
            _Person.Address = txtAddress.Text;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.NationalityCountryID = clsCountry.GetCountryIDByCountryName(cbCountry.Text);
            if (PersonImage.ImageLocation != null)
            {
                _Person.ImagePath = PersonImage.ImageLocation;
            }
            else _Person.ImagePath = "";



            if (_Person.Save())
            {
                lbTitle.Text = "Update Person";
                FormMode = enMode.UpdatePerson;
                _PersonID = _Person.PersonID;
                lbPersonID.Text = _Person.PersonID.ToString();

                MessageBox.Show("Data Saved Successfuly ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Person.PersonID);
               
            }
            else { MessageBox.Show("Sorry We Couldn't Save Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    
    
    }
}

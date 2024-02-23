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

namespace DVDL.Pepole
{
    public partial class ctrPersonInfo : UserControl
    {
        private int _PersonID;
        private clsPerson _Person;

        public ctrPersonInfo()
        {
            InitializeComponent();
            EditPersonLink.Visible = false;
            

        }

        public clsPerson Person { get { return _Person; } }

        private void EditPersonLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form MyForm = new frmAddUpdatePerson(_Person.PersonID);
           MyForm.ShowDialog();
            LoadPersonInfo(_Person.PersonID);
            
        }
        public void LoadImages() 
        {

            if (_Person.ImagePath == "" || _Person.ImagePath == null) ImageProfile.Image = (_Person.Gender==0 )? Resources.Male_512 : Resources.Male_512; //Resources.Female_512;
            else { ImageProfile.ImageLocation = _Person.ImagePath; ImageProfile.Load(_Person.ImagePath); }
            GenderImage.Image = (_Person.Gender == 0) ? Resources.Man_32 : Resources.Woman_32;
        }
        public void LoadPersonInfo(int PersonID) 
        {
            _Person = clsPerson.FindPersonByID(PersonID);
            if (_Person != null)
            {

                lbName.Text     = _Person.FirstName + " " + _Person.LastName;
                lbPersonID.Text = _Person.PersonID.ToString();
                lbEmail.Text    = _Person.Email;
                lbPhone.Text    = _Person.Phone;
                this.Name       = _Person.FirstName + ' ' + _Person.SecondName + ' ' + _Person.ThirdName + ' ' + _Person.LastName;
                lbBirthDate.Text= _Person.BirthDate.ToString("d");
                lbAddress.Text  = _Person.Address;
                lbNationalNumber.Text= _Person.NationalNumber;
                lbCountry.Text = clsCountry.GetCountryByID(_Person.NationalityCountryID).CountryName;
                lbGender.Text = (_Person.Gender == 1) ? "Female" : "Male";
                LoadImages();
                EditPersonLink.Visible = true;
            }
            else { ResetInfo(); }
        }

        public void LoadPersonInfo(string FirstName)
        {
            _Person = clsPerson.FindPersonByFirstName(FirstName);
            if (_Person != null)
            {

                lbName.Text = _Person.FirstName + ' ' + _Person.SecondName + ' ' + _Person.LastName;
                lbPersonID.Text = _Person.PersonID.ToString();
                lbEmail.Text = _Person.Email;
                lbPhone.Text = _Person.Phone;
               
                lbBirthDate.Text = _Person.BirthDate.ToString("d");
                lbAddress.Text = _Person.Address;
                lbNationalNumber.Text = _Person.NationalNumber;
                lbCountry.Text = clsCountry.GetCountryByID(_Person.NationalityCountryID).CountryName;
                lbGender.Text = (_Person.Gender == 1) ? "Female" : "Male";
                LoadImages();
                EditPersonLink.Visible = true;
            }
            else { ResetInfo(); }
        }
        public void ResetInfo() 
        {
            lbName.Text ="[???]";
            lbPersonID.Text = "[???]";
            lbEmail.Text = "[???]";
            lbPhone.Text = "[???]";
            this.Name = "[???]";
            lbBirthDate.Text = "[???]";
            lbAddress.Text = "[???]";
            lbNationalNumber.Text = "[???]";
            lbCountry.Text = "[???]";
            lbGender.Text = "Male";
            EditPersonLink.Visible = false;
            ImageProfile.Image = Resources.Male_512;

        }
        private void ctrPersonInfo_Load(object sender, EventArgs e)
        {

            ResetInfo();


        }
    }
}

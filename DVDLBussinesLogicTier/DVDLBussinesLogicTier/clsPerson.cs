using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DVDLAccessDataTier;
namespace DVDLBussinesLogicTier
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string NationalNumber { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + SecondName + " " + LastName; } }
        public DateTime BirthDate { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set;}
        public string GenderText { get { return (Gender == 1) ? "Female" : "Male"; } }
        public enum enMode {AddNewPerson = 0 , UpdatePerson=1 };
        
        public enMode FormMode;
       
        public clsCountry CountryInfo;
        public clsPerson()
        {
            this.PersonID   = -1;
            this.FirstName  = "";
            this.LastName   = "";
            this.ThirdName  = "";
            this.SecondName = "";
            this.Gender     = 0;
            this.Address    = "";
            this.BirthDate  = DateTime.Now;
            this.Email      = "";
            this.ImagePath  = "";
            this.Phone      = "";
            this.NationalNumber = "";
            this.NationalityCountryID = 0;
            FormMode = enMode.AddNewPerson;

        }
        private clsPerson(int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName, string LastName, DateTime BirthDate, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath) 
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ThirdName = ThirdName;
            this.SecondName = SecondName;
            this.Gender = Gender;
            this.Address = Address;
            this.BirthDate = BirthDate;
            this.Email = Email;
            this.ImagePath = ImagePath;
            this.Phone =Phone;
            this.NationalNumber = NationalNumber;
            this.NationalityCountryID = NationalityCountryID;
            this.CountryInfo = clsCountry.GetCountryByID(NationalityCountryID);
            FormMode = enMode.UpdatePerson;
        }
        public static clsPerson FindPersonByID(int PersonID) 
        {
             string NationalNumber ="" ,FirstName="", SecondName="", ThirdName="", LastName="", Email="", Phone="", Address="", ImagePath="";
            int NationalityCountryID = -1;
            byte Gender = 0;
            DateTime BirthDate = System.DateTime.Now;
            if (clsPeopleDataAccess.FindPersonByID(PersonID, ref NationalNumber,ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref BirthDate,ref  Gender, ref Address,ref Phone,ref Email, ref NationalityCountryID, ref ImagePath) )
            {
                clsPerson Person = new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
               
                return Person;
            }

            return null;
        
        }
        public static clsPerson FindPersonByNationalNo(string  NationalNo)
        {
            int PersonID = -1;string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            byte Gender = 0;
            DateTime BirthDate = System.DateTime.Now;
            if (clsPeopleDataAccess.FindPersonByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref BirthDate, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                clsPerson Person = new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

                return Person;
            }

            return null;

        }
        public static clsPerson FindPersonByFirstName(string FirstName)
        {
            int PersonID = -1;
            string NationalNumber = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            byte Gender = 0;
            DateTime BirthDate = System.DateTime.Now;
            if (DVDLAccessDataTier.clsPeopleDataAccess.FindPersonByFirstName(ref PersonID, ref NationalNumber,  FirstName, ref SecondName, ref ThirdName, ref LastName, ref BirthDate, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                clsPerson Person = new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

                return Person;
            }

            return null;

        }
        public static clsPerson FindPersonByLastName(string LastName)
        {
            int PersonID = -1;
            string NationalNumber = "", SecondName = "", ThirdName = "", FirstName ="", Email = "", Phone = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            byte Gender = 0;
            DateTime BirthDate = System.DateTime.Now;
            if (DVDLAccessDataTier.clsPeopleDataAccess.FindPersonByFourthName(ref PersonID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName,  LastName, ref BirthDate, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                clsPerson Person = new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

                return Person;
            }

            return null;

        }
        public static clsPerson FindPersonBySecondName(string SecondName)
        {
            int PersonID = -1;
            string NationalNumber = "", LastName = "", ThirdName = "", FirstName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            byte Gender = 0;
            DateTime BirthDate = System.DateTime.Now;
            if (DVDLAccessDataTier.clsPeopleDataAccess.FindPersonBySecondName(ref PersonID, ref NationalNumber, ref FirstName,  SecondName, ref ThirdName, ref LastName, ref BirthDate, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                clsPerson Person = new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

                return Person;
            }

            return null;

        }
        public static clsPerson FindPersonByPhone(string Phone)
        {
            int PersonID = -1;
            string NationalNumber = "", LastName = "", ThirdName = "", FirstName = "", Email = "", SecondName = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            byte Gender = 0;
            DateTime BirthDate = System.DateTime.Now;
            if (DVDLAccessDataTier.clsPeopleDataAccess.FindPersonByPhone(ref PersonID, ref NationalNumber, ref FirstName, SecondName, ref ThirdName, ref LastName, ref BirthDate, ref Gender, ref Address,  Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                clsPerson Person = new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

                return Person;
            }

            return null;

        }
        public static clsPerson FindPersonByEmail(string Email)
        {
            int PersonID = -1;
            string NationalNumber = "", LastName = "", ThirdName = "", FirstName = "", Phone = "", SecondName = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            byte Gender = 0;
            DateTime BirthDate = System.DateTime.Now;
            if (DVDLAccessDataTier.clsPeopleDataAccess.FindPersonByEmail(ref PersonID, ref NationalNumber, ref FirstName,ref SecondName, ref ThirdName, ref LastName, ref BirthDate, ref Gender, ref Address, ref Phone,  Email, ref NationalityCountryID, ref ImagePath))
            {
                clsPerson Person = new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

                return Person;
            }

            return null;

        }
        public static clsPerson FindPersonByGender(string Email)
        {
            int PersonID = -1;
            string NationalNumber = "", LastName = "", ThirdName = "", FirstName = "", Phone = "", SecondName = "", Address = "", ImagePath = "";
            int NationalityCountryID = -1;
            byte Gender = 0;
            DateTime BirthDate = System.DateTime.Now;
            if (DVDLAccessDataTier.clsPeopleDataAccess.FindPersonByGender(ref PersonID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref BirthDate, Gender, ref Address, ref Phone,ref Email, ref NationalityCountryID, ref ImagePath))
            {
                clsPerson Person = new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

                return Person;
            }

            return null;

        }
       
        public static DataTable GetAllPepole() 
        {
            DataTable People = DVDLAccessDataTier.clsPeopleDataAccess.GetAllPeople();
            return People;
        }
        private  bool  _AddPerson(string NationalNumber , string FirstName,string SecondName,string ThirdName,string LastName,DateTime BirthDate, byte Gender , string Address , string Phone, string Email,int NationalityCountryID,string ImagePath) 
        {
           this.PersonID = DVDLAccessDataTier.clsPeopleDataAccess.AddPerson(NationalNumber, FirstName, SecondName, ThirdName, LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            
            return (PersonID!=-1);
        }
        public static bool DeletePerson(int PersonID)
        {
            return DVDLAccessDataTier.clsPeopleDataAccess.DeletePerson(PersonID);
        }
        private static bool _UpdatePerson(int personID,string NationalNumber, string FirstName, string SecondName, string ThirdName,string LastName, DateTime BirthDate, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            return DVDLAccessDataTier.clsPeopleDataAccess.UpdatePerson(personID, NationalNumber, FirstName, SecondName, ThirdName,LastName,BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
       
        }
        public static bool isPersonExsist(string NationalNo) 
        {

            return DVDLAccessDataTier.clsPeopleDataAccess.IsPersonExsist(NationalNo);

        }
        public static bool isPersonExsist(int personID)
        {

            return DVDLAccessDataTier.clsPeopleDataAccess.IsPersonExsist(personID);

        }
        public  bool Save() 
        {

            if (this.FormMode == enMode.UpdatePerson)
            {
                return _UpdatePerson(this.PersonID, this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.BirthDate, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            }
            else 
            {
                FormMode = enMode.UpdatePerson;
                return _AddPerson(this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.BirthDate, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            } 

        }
    }
}

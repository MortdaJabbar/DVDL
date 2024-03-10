using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDLAccessDataTier;
namespace DVDLBussinesLogicTier
{
    public class clsUser
    {
        public enum enMode {AddNewUser=1 , UpdateUser=2 , UpdatePassword}
        public bool   isActive { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int    UserID { get; set; }
        public string FullName { get; set; }
        public enMode Mode { get; set; }

        public clsPerson Person;
        public clsUser() 
        {
            this.Person = null;
            this.UserID = -1;
            this.UserName = "";
            this.FullName = "";
            this.Password = "";
            this.isActive = false;
            Mode = enMode.AddNewUser;
        }
        public clsUser(int UserID,int PersonID,string UserName,string Password,bool IsActive)
        {
            this.Person = clsPerson.FindPersonByID(PersonID);
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.isActive = IsActive;
            this.FullName = Person.FirstName + " " + Person.SecondName + Person.ThirdName + " " + Person.LastName;
            Mode = enMode.UpdateUser;
        }
        public static clsUser FindUserByUserID(int UserID)
        {
            int PersonID = -1 ; 
            string UserName = "", Password = "";
            bool IsActive = false;
            if (DVDLAccessDataTier.clsUser.FindUserByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive)) 
            {
              
                return new clsUser(UserID,PersonID,UserName,Password,IsActive);
            }
            return null;
        }
        public static clsUser FindUserByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;
            if (DVDLAccessDataTier.clsUser.FindUserByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            return null;
        }
        public static clsUser FindUserByUserNameAndPassword( string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;
            if (DVDLAccessDataTier.clsUser.FindUserByUserNameAndPassword(ref UserID, ref PersonID,  UserName, Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            return null;
        }
        public static bool isUserExsistByUserID(int UserID) 
        {
            return DVDLAccessDataTier.clsUser.IsUserExsistByUserID(UserID);
        }
        public static bool isUserExsistByPersonID(int PersonID)
        {
            return DVDLAccessDataTier.clsUser.IsUserExsistByPersonID(PersonID);
        }
        public static bool isUserExsist(string UserName,string Password)
        {
            return DVDLAccessDataTier.clsUser.IsUserExsistByUserNameAndPassword(UserName,Password);
        }
        public static DataTable GetAllUsers() 
        {
            return DVDLAccessDataTier.clsUser.GetAllUsers();
        } 
        private  bool _AddNewUser(int PersonID,string UserName,string Password,bool isActive)
        {
            this.UserID = DVDLAccessDataTier.clsUser.AddUser(PersonID, UserName, Password, isActive);
            return (this.UserID!= -1);
        }
        private bool _UpdateUser(int UserID,int PersonID, string UserName, string Password, bool isActive)
        {
          return  DVDLAccessDataTier.clsUser.UpdateUser(UserID,PersonID, UserName, Password, isActive);
         
        }
        public bool ChangePassword() 
        {
            return DVDLAccessDataTier.clsUser.ChangePassword(this.UserName, this.Password);
        
        }
        public  bool Save() 
        {
            switch (this.Mode) 
            {
                case enMode.AddNewUser:
                    {
                        if (_AddNewUser(this.Person.PersonID, this.UserName, this.Password, this.isActive))
                        {
                            this.Mode = enMode.UpdateUser;
                            return true;
                        }
                        
                    }break;

                case enMode.UpdateUser:
                    {
                        return _UpdateUser(this.UserID, this.Person.PersonID, this.UserName, this.Password, this.isActive);
                    }
                 

            }
            return false;
        }
        public static bool DeleteUser(int UserID) 
        {
            return DVDLAccessDataTier.clsUser.DeleteUser(UserID);
        }
    
    
    }
}

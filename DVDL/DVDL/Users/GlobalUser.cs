using DVDLBussinesLogicTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL.Users
{
    internal class Global
    {

        private static string _Loginfile = "C:\\Users\\User\\Desktop\\login.txt";
        public static clsUser CurrentUser { get; set; }
        private static bool IsLoginFileExsist() 
        {
            return File.Exists(_Loginfile);
        
        }
        public static void StoreUserInfoInFile(string UserName , string Password) 
        {
           
            if (UserName.Trim() == "" || Password.Trim() == "")
            {
                if (File.Exists(_Loginfile)) 
                {
                File.Delete(_Loginfile);
                }return;
            }


            File.WriteAllText(_Loginfile,$"{UserName}\n{Password}");

        }
        public static bool GetStoredUser(ref string UserName, ref string Password)
        {
            if (!IsLoginFileExsist()) return false;
            string [] Userinfo = File.ReadAllLines(_Loginfile);
            if (Userinfo.Length > 0)
            {
                UserName = Userinfo[0];
                Password = Userinfo[1];
                return true;
            }
             return false;
        }
    }
}

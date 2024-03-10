using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLAccessDataTier
{
    public class Global
    {
        public static void LogEvent(string Soure, string Message, EventLogEntryType type)
        {
            if (!(EventLog.SourceExists(Soure)))
            {
                EventLog.CreateEventSource(Soure, "Application");
            }

            EventLog.WriteEntry(Soure, Message, type);
        }
        private static string _Loginfile = "C:\\Users\\User\\Desktop\\login.txt";
        public static clsUser CurrentUser { get; set; }
        private static bool IsLoginFileExsist()
        {
            return File.Exists(_Loginfile);

        }
        public static void StoreUserInfoInRegistry(string UserName, string Password)
        {

            if (UserName.Trim() == "" || Password.Trim() == "")
            {
                if (File.Exists(_Loginfile))
                {
                    File.Delete(_Loginfile);
                }
                return;
            }


            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVDL\USERLOGININFO";

            try
            {
                Registry.SetValue(KeyPath, "UserName", UserName, RegistryValueKind.String);
                Registry.SetValue(KeyPath, "Password", Password, RegistryValueKind.String);


            }
            catch (Exception e) { MessageBox.Show(e.Message); }


        }
        public static bool GetStoredUser(ref string UserName, ref string Password)
        {
            if (!IsLoginFileExsist()) return false;
            string[] Userinfo = File.ReadAllLines(_Loginfile);
            if (Userinfo.Length > 0)
            {
                UserName = Userinfo[0];
                Password = Userinfo[1];
                return true;
            }
            return false;
        }
        public static bool GetStoredUserInRegistry(ref string UserName, ref string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVDL\USERLOGININFO";
            string? StoredUserName = "";
            string? StoredPassword = "";
            try
            {
                StoredUserName = Registry.GetValue(KeyPath, "UserName", null) as string;
                StoredPassword = Registry.GetValue(KeyPath, "Password", null) as string;
                if (StoredPassword == null || StoredUserName == null)
                {
                    UserName = "";
                    Password = "";
                    return false;
                }
            }
            catch (Exception e) { MessageBox.Show($"{e.Message}"); }

            UserName = StoredUserName;
            Password = StoredPassword;
            return true;
        }
    }
}

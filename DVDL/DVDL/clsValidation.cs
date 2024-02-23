using DVDL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVDL
{
    public static class clsValidation
    {
        public static bool ValidateEmail(string email) 
        {
        string RegExpression = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
         bool isMatch = Regex.IsMatch(email,RegExpression,RegexOptions.IgnoreCase);
            
            return isMatch;
        }
        public static bool ValidateNumber(string txtNumber)
        {
            return  (int.TryParse(txtNumber, out int x));
        }
        public static bool isValidPassword(string Password) 
        {
            Regex reg = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

            return reg.IsMatch(Password);
        }
    }
}

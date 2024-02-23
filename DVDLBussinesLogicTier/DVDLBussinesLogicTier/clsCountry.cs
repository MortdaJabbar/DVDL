using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinesLogicTier
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

      
        public static DataTable GetAllCountries() 
        {
            DataTable Countries = DVDLAccessDataTier.clsCountryDataAccess.GetAllCountries();
            return Countries;
        }
        public static clsCountry GetCountryByID(int CountryID)
        {
            string CountryName = "";
            if (DVDLAccessDataTier.clsCountryDataAccess.GetCountryByID(CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            return null;
           
        }
        public   clsCountry(int CountryID, string CountryName)
        {
            this.CountryID   = CountryID;
            this.CountryName = CountryName;
        }

        public static int GetCountryIDByCountryName(string CountryName)
        {
            return DVDLAccessDataTier.clsCountryDataAccess.GetCountryIDByCountryName(CountryName);

        }

    }
}

using System;
using System.Data;
using System.Data.SqlClient;
namespace DVDLAccessDataTier
{
    public class clsCountryDataAccess
    {
        public static DataTable GetAllCountries() 
        {
            string query = "select * from Countries";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            
            SqlCommand Command  = new SqlCommand(query, Connection);
            DataTable Countries = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Countries.Load(Reader);
                }
                Reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally { Connection.Close(); }
            return Countries;
        }
        public static bool GetCountryByID(int CountryID,ref string CountryName)
        {
            string query = "select * from Countries Where CountryID = @CountryID ";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);

            SqlCommand Command = new SqlCommand(query, Connection);
            bool Found = false;
            Command.Parameters.AddWithValue("CountryID", CountryID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Found = true;
                    CountryName= Reader["CountryName"].ToString();
                }
                Reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally { Connection.Close(); }
            return Found;
        }
        public static int GetCountryIDByCountryName(string CountryName)
        {
            string query = "select * from Countries Where CountryName = @CountryName ";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("CountryName", CountryName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    return Convert.ToInt32(Reader["CountryID"]);
                }
                Reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally { Connection.Close(); }
            return -1;
        }

    }
    
}
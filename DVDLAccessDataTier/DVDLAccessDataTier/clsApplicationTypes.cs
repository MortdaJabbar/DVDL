using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLAccessDataTier
{
    public class clsApplicationTypes
    {
        
        public static DataTable GellApplicationTypes()
        {
            DataTable ApplicationTypes = new DataTable();
            string query = "select * from ApplicationTypes;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);    
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                while (Reader!=null)
                {
                    ApplicationTypes.Load(Reader);
                    Reader.Read();
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return ApplicationTypes;

        }
        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle , Decimal ApplicationFees)
        {
            string query = @"update  ApplicationTypes 
                    set   ApplicationFees=@ApplicationFees,
                          ApplicationTypeTitle=@ApplicationTypeTitle
                    Where ApplicationTypeID = @ApplicationTypeID";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            try
            {
                connection.Open();
                int Rows = command.ExecuteNonQuery();

                if (Rows > 0) { Updated = true; }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Updated;
          
        }
        public static bool FindApplicationTyepByID(int ApplicationTypeID,ref string ApplicationTypeTitle, ref Decimal ApplicationFees) 
        {
            bool Found = false;
            string query = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationTypeTitle = Reader["ApplicationTypeTitle"].ToString();
                    ApplicationFees = Convert.ToDecimal(Reader["ApplicationFees"]);

                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }



    }
}

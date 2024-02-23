using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLAccessDataTier
{
    public class clsLicenseClassesData
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable LicenseClasses = new DataTable();
            string query = "select * from LicenseClasses;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    LicenseClasses.Load(Reader);
                   
                }

                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return LicenseClasses;

        }
        public static bool FindLicenseClassesByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge,ref byte DefaultValidityLength,ref Decimal ClassFees)
        {
            bool Found = false;
            string query = "select * from LicenseClasses where LicenseClassID = @myLicenseClassID";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myLicenseClassID", LicenseClassID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader .Read())
                {
                    ClassName = Reader["ClassName"].ToString();
                    ClassDescription = Reader["ClassDescription"].ToString();
                    MinimumAllowedAge = Convert.ToByte(Reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToByte(Reader["DefaultValidityLength"]);
                    ClassFees  = Convert.ToDecimal(Reader["ClassFees"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindLicenseClassesByClassName(string ClassName ,ref int LicenseClassID, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref Decimal ClassFees)
        {
            bool Found = false;
            string query = "select * from LicenseClasses where ClassName = @ClassName";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    LicenseClassID = (int)Reader["LicenseClassID"];
                    ClassDescription = Reader["ClassDescription"].ToString();
                    MinimumAllowedAge = Convert.ToByte(Reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToByte(Reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToDecimal(Reader["ClassFees"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static int AddLicenseClasse( string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength,  Decimal ClassFees)
        {
            string query = @"insert into LicenseClasses 
                    (ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees)
                    values(@ClassName,@ClassDescription,@MinimumAllowedAge,@DefaultValidityLength,@ClassFees); SELECT SCOPE_IDENTITY();";
            int LicenseClassID = -1;

            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(),out int InsertedID)) { LicenseClassID = InsertedID; }
                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return LicenseClassID;
        }
        public static bool UpdateLicenseClasse(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, Decimal ClassFees)
        {
            string query = @"update  LicenseClasses 
                    set ClassName=@ClassName,
                        ClassDescription=@ClassDescription ,
                        MinimumAllowedAge=@MinimumAllowedAge ,
                        DefaultValidityLength=@DefaultValidityLength,
                        ClassFees=@ClassFees,
                    Where LicenseClassID = @LicenseClassID";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

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
        public static bool DeleteLicenseClasse(int LicenseClassID)
        {
            bool Deleted = false;
            string query = @"DELETE FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                int row = command.ExecuteNonQuery();
                if (row > 0) { Deleted = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally { connection.Close(); }
            return Deleted;
        }



    
    }
}

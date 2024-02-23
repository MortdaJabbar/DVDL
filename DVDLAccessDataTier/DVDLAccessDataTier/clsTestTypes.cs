using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Collections;

namespace DVDLAccessDataTier
{
    public class clsTestTypes
    {

        public static DataTable GellTestTypes()
        {
            DataTable TestTypes = new DataTable();
            string query = "select * from TestTypes;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                while (Reader!=null)
                {
                    TestTypes.Load(Reader);
                    Reader.Read();
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return TestTypes;

        }
        public static bool UpdateTestType(int TestTypeID,  string TestTypeTitle,  string TestTypeDescription ,  Decimal TestTypeFees)
        {
            string query = @"update TestTypes
                    set TestTypeTitle = @TestTypeTitle,
                        TestTypeDescription = @TestTypeDescription,
                        TestTypeFees = @TestTypeFees
                    Where TestTypeID = @TestTypeID";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
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
        public static bool FindTestTypeByID(int TestTypeID ,ref string TestTypeTitle, ref string TestTypeDescription,ref Decimal TestTypeFees) 
        {
            string Query = @"exec spGetTestTypeByID @TestTypeID;";

            bool Found = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
          
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read()) 
                {
                    TestTypeTitle = Reader["TestTypeID"].ToString();
                    TestTypeDescription = Reader["TestTypeDescription"].ToString();
                    TestTypeFees = (Decimal)Reader["TestTypeFees"];
                    Found = true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Found;
        }
    
    
    
    }
}

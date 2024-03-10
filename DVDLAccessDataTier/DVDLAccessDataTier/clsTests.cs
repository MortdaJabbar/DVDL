using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DVDLAccessDataTier
{
    public class clsTests
    {
      public static DataTable GellTests()
        {
            DataTable Tests = new DataTable();
            string query = "select * from Tests;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Tests.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return Tests;

        }
      public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes , int CreatedByUserID)
        {
            string query = @"exec uspUpdateTest @TestID , @TestAppointmentID  ,@TestResult  ,@Notes  ,@CreatedByUserID;";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                int Rows = command.ExecuteNonQuery();

                if (Rows > 0) { Updated = true; }
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Updated;
        }
      public static bool FindTestByID(int TestID,ref  int TestAppointmentID, ref  bool  TestResult, ref string Notes,ref int CreatedByUserID)
        {
            bool Found = false;
            string query = "exec uspGetTestByTestID @TestID;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@TestID", TestID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    TestAppointmentID = Convert.ToInt32(Reader["TestAppointmentID"]);
                    TestResult = Convert.ToBoolean(Reader["TestResult"]);
                    Notes = (Reader["Notes"]).ToString();
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                   
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
      public static int AddTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int TestID = -1;
            string query = @"exec uspAddNewTest @TestAppointmentID,@TestResult,@Notes,@CreatedByUserID;";
           
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            

            try
            {
                connection.Open();
                object  Result = command.ExecuteScalar();
                if(Result!=null && int.TryParse( Result.ToString(),out int InsertedID))
                {
                    TestID = InsertedID;
                }
                
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return TestID;
        }
      public static bool DeleteTest(int TestID)
        {
            bool Deleted = false;
            string query = @"DELETE FROM Tests WHERE TestID = @TestID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);
            try
            {
                connection.Open();
                int row = command.ExecuteNonQuery();
                if (row > 0) { Deleted = true; }
            }
            catch (Exception ex)
            {
                Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error);
                Console.WriteLine($"{ex.Message}");
            }
            finally { connection.Close(); }
            return Deleted;
        }
    }
}

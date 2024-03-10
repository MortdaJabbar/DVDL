using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;

using System.Diagnostics;

namespace DVDLAccessDataTier
{
    public  class clsLicensesData
    {
        public static DataTable GetAllLicensesFormated()
        {
            DataTable Licenses = new DataTable();
            string query = "exec  uspGetAllLicenesFormated;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    Licenses.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return Licenses;

        }
        public static DataTable GetAllLicensesForPerson(int PersonID)
        {
            DataTable dt = new DataTable();
            string Query = @"exec uspGetAllLicenseForPerson @PersonID;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                while (Reader != null)
                {
                    dt.Load(Reader);
                    Reader.Read();
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return dt;


        }
        public static bool FindLicenseByID(int LicenseID, ref int ApplicationID, ref int DriverID,ref int LicenseClass,ref DateTime IssueDate,ref DateTime ExpirationDate,ref string Notes, ref Decimal PaidFees,ref  bool IsActive, ref byte IssueReason,ref  int CreatedByUserID)
        {
            bool Found = false;
            string query = "select * from Licenses where LicenseID = @LicenseID";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationID = Convert.ToInt32(Reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(Reader["DriverID"]);
                    LicenseClass = Convert.ToInt32(Reader["LicenseClass"]);
                    IssueDate = Convert.ToDateTime(Reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(Reader["ExpirationDate"]);
                    if (Reader["Notes"] == DBNull.Value) { Notes = ""; }
                    else Notes = Reader["Notes"].ToString();
                    PaidFees = Convert.ToDecimal(Reader["PaidFees"]);
                    IsActive = Convert.ToBoolean(Reader["IsActive"]);
                    IssueReason = Convert.ToByte(Reader["IssueReason"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static int  AddLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, Decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LiceseID = -1;
            string query = @"insert into Licenses(ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)
                    values(@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID);Select Scope_identity();";
           
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result!=null && int.TryParse(Result.ToString(),out int InsertedID)) {LiceseID = InsertedID;}
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return LiceseID;
        }
        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes,Decimal PaidFees,bool IsActive, byte IssueReason,int CreatedByUserID)
        {
            string query = @"update  Licenses 
                    set ApplicationID=@ApplicationID
                    , DriverID=@DriverID
                    , LicenseClass=@LicenseClass
                    , IssueDate=@IssueDate
                    , ExpirationDate=@ExpirationDate
                    , Notes=@Notes
                    , PaidFees=@PaidFees
                    , IsActive=@IsActive 
                    , IssueReason = @IssueReason
                    , CreatedByUserID = CreatedByUserID
                    Where LicenseID = @LicenseID";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
        public static bool isLicenseDetained(int LicenseID) 
        {
            string Query = @" exec uspIsLicenseDetained @LicenseID;";
            bool Detained = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Detained = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Detained;
        }
        public static int GetLicenseIDByApplicationID(int LicenseClassID,int ApplicationID)
        {
            string Query = @"exec uspGetLicenseByApplicationID @LicenseClassID , @ApplicationID;";
            int LicneseID = -1;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) 
                {
                    LicneseID = Convert.ToInt32(reader["LicenseID"]);
                }
                reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return LicneseID;
        }
        public static bool DeleteLicense(int LicenseID)
        {
            bool Deleted = false;
            string query = @"DELETE FROM Licenses WHERE LicenseID = @LicenseID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
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
        public static int GetRenewdLicenseID(int LicneseClassID , int DriverID) 
        {
            int RenewLicenseID = -1;
            string Query = @"exec isLicenseRenewed @LicenseClassID  , @DriverID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicneseClassID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID)) { RenewLicenseID = InsertedID; }
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return RenewLicenseID;


        }
        public static int GetReplacedLicenseID(int LicneseClassID, int DriverID)
        {
            int RenewLicenseID = -1;
            string Query = @"exec isLicenseReplaced @LicenseClassID  , @DriverID ;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicneseClassID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID)) { RenewLicenseID = InsertedID; }
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return RenewLicenseID;


        }
        public static bool DeactivateLicense(int LicenseID) 
        {
            bool Updated = false;
            string Query = @"update Licenses set IsActive=0 Where LicenseID = @LicenseID";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                int Rows = command.ExecuteNonQuery();
                Updated = (Rows > 0);
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return Updated;
        }
        public static bool IsLicneseExsist(int LicenseID)
        {
            bool Found = false;
            string Query = @"select Found=1 from  Licenses Where LicenseID = @LicenseID";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                object  Result = command.ExecuteScalar();
                Found = (Result != null);
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return Found;
        }

    }
}

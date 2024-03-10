using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DVDLAccessDataTier
{
    public class clsDetainedLicenseData
    {
        public static bool FindDetainLicenseByID(int DetainID ,ref int LicenseID,ref DateTime DetainDate,ref Decimal FineFees,ref int CreatedByUserID,ref bool IsReleased,ref DateTime ReleaseDate,ref int ReleasedByUserID,ref int ReleaseApplicationID)
        {
            bool Found = false;
            string Query = "select * from DetainedLicenses Where DetainID =@DetainID";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read()) 
                {
                    LicenseID       = (int)Reader["LicenseID"];
                    LicenseID       = (int)Reader["LicenseID"];
                    DetainDate      = Convert.ToDateTime(Reader["DetainDate"]);
                    FineFees        = Convert.ToDecimal(Reader["FineFees"]);
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased      = (bool)Reader["IsReleased"];
                    if (Reader["ReleaseDate"] != DBNull.Value) { ReleaseDate = Convert.ToDateTime(Reader["ReleaseDate"]); }
                    else ReleaseDate = new DateTime(0, 0, 0);
                    if (Reader["ReleasedByUserID"] != DBNull.Value) { ReleasedByUserID = (int)(Reader["ReleasedByUserID"]); }
                    else ReleasedByUserID = -1;
                    if (Reader["ReleaseApplicationID"] != DBNull.Value) { ReleasedByUserID = (int)(Reader["ReleaseApplicationID"]); }
                    else ReleaseApplicationID = -1;
                    Found = true;
                }
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Found;

        } 
        public static int AddDetainLicnese(int LicenseID, DateTime DetainDate, Decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int DetainID = -1;
            string Query = @"exec uspAddNewDetain @LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate, @ReleasedByUserID,@ReleaseApplicationID; ";

            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (!IsReleased)
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID)) { DetainID = InsertedID; }
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return DetainID;


        }
        public static bool  UpdateDetainLicnese(int DetainID,int LicenseID, DateTime DetainDate, Decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool Updated = false; 
            string Query = @"exec uspUpdateDetainedLicense  @DetainID,@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID;";

            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (!IsReleased)
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }

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
        public static bool ReleaseDetainedLicense(int DetainID, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool Updated = false;
            string Query = @"Update DetainedLicenses  
                             set IsReleased = 1 ,
                                 ReleaseDate=@ReleaseDate,
                                 ReleasedByUserID=@ReleasedByUserID,
                                 ReleaseApplicationID=@ReleaseApplicationID";

            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
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
        public static bool IsLicenseDetained(int LicenseID) 
        {
            string Query = @"exec  uspIsLicenseDetained @LicenseID;";
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                Found= Reader.HasRows;
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Found;

        }
        public static bool FindDetainLicenseByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref Decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool Found = false;
            string Query = "exec uspGetDetainLiceseByLicenseID @LicenseID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                   
                    DetainID = (int)Reader["DetainID"];
                    DetainDate = Convert.ToDateTime(Reader["DetainDate"]);
                    FineFees = Convert.ToDecimal(Reader["FineFees"]);
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];
                    if (Reader["ReleaseDate"] != DBNull.Value) { ReleaseDate = Convert.ToDateTime(Reader["ReleaseDate"]); }
                    else ReleaseDate = DateTime.MinValue;
                    if (Reader["ReleasedByUserID"] != DBNull.Value) { ReleasedByUserID = (int)(Reader["ReleasedByUserID"]); }
                    else ReleasedByUserID = -1;
                    if (Reader["ReleaseApplicationID"] != DBNull.Value) { ReleasedByUserID = (int)(Reader["ReleaseApplicationID"]); }
                    else ReleaseApplicationID = -1;
                    Found = true;
                }
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Found;

        }
        public static bool GetDetainIDByLicenseID(int LicenseID, ref int DetainID)
        {
            bool Found = false;
            string Query = "exec uspGetDetainLiceseByLicenseID @LicenseID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {

                    DetainID = (int)Reader["DetainID"];
                    Found = true;
                }
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Found;

        }
        public static DataTable GetAllDetainedLicenses() 
        {
            DataTable dt = new DataTable();

            string query = "exec GetFullDetainedLicenseinfoFormated;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return dt;

        }

    }
}

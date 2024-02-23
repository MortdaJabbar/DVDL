using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DVDLAccessDataTier
{
    public class clsApplicationsData
    {
        public static DataTable GellApplications()
        {
            DataTable Applications = new DataTable();
            string query = "select * from Applications;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows )
                {
                    Applications.Load(Reader);
                
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return Applications;

        }
        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate , Decimal PaidFees, int CreatedByUserID)
        {
            string query = @"update  Applications 
                    set ApplicantPersonID=@ApplicantPersonID
                    , ApplicationDate=@ApplicationDate
                    , ApplicationTypeID=@ApplicationTypeID
                    , ApplicationStatus=@ApplicationStatus
                    , LastStatusDate =@LastStatusDate
                    , PaidFees = @PaidFees
                    , CreatedByUserID =@CreatedByUserID
                    Where ApplicationID = @ApplicationID;";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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
        public static bool FindApplicationByID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref Decimal PaidFees, ref int CreatedByUserID)
        {
            bool Found = false;
            string query = "select * from Applications where ApplicationID = @ApplicationID";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                   
                    ApplicantPersonID = Convert.ToInt32(Reader["ApplicantPersonID"]);
                    ApplicationTypeID = Convert.ToInt32(Reader["ApplicationTypeID"]);
                    ApplicationDate   = Convert.ToDateTime(Reader["ApplicationDate"]);
                    ApplicationStatus = Convert.ToByte(Reader["ApplicationStatus"]);
                    PaidFees          = Convert.ToDecimal(Reader["PaidFees"]);
                    LastStatusDate    = Convert.ToDateTime(Reader["LastStatusDate"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindApplicationByPersonID(int ApplicantPersonID, ref int ApplicationID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref Decimal PaidFees, ref int CreatedByUserID)
        {
            bool Found = false;
            string query = "select * from Applications where ApplicantPersonID = @ApplicantPersonID";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationID = Convert.ToInt32(Reader["ApplicationID"]);
                    ApplicationTypeID = Convert.ToInt32(Reader["ApplicationTypeID"]);
                    ApplicationDate = Convert.ToDateTime(Reader["ApplicationDate"]);
                    ApplicationStatus = Convert.ToByte(Reader["ApplicationStatus"]);
                    PaidFees = Convert.ToDecimal(Reader["PaidFees"]);
                    LastStatusDate = Convert.ToDateTime(Reader["LastStatusDate"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static int AddApplication (int ApplicantPersonID,  DateTime ApplicationDate,  int ApplicationTypeID,  byte ApplicationStatus,  DateTime LastStatusDate,  Decimal PaidFees,  int CreatedByUserID)
        {
            string query = @"insert into Applications 
                          (ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
                   values(@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID); SELECT SCOPE_IDENTITY(); ";
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(),out int InsertedID)) { ApplicationID = InsertedID; }
             
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return ApplicationID;
        }
        public static bool DeleteApplication(int ApplicationID)
        {
            bool Deleted = false;
            string query = @"DELETE FROM Applications WHERE ApplicationID = @ApplicationID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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
        public static bool UpdateApplicationStatusMode(int ApplicationID, byte ApplicationStatus) 
        {
            bool Update = false;
            string Query = @"Update Applications set ApplicationStatus = @ApplicationStatus Where ApplicationID=@ApplicationID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            try
            {
                connection.Open();
                int Rows = command.ExecuteNonQuery();

                if (Rows > 0) { Update = true; }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Update;
        }

    }
}

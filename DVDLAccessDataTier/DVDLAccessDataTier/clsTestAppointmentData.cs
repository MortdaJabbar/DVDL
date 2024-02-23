using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLAccessDataTier
{
    public class clsTestAppointmentData
    {
        public static DataTable GetAllTestAppointment()
        {
            string Query = "select * from TestAppointments;";
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
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
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return dt;

        }
        public static DataTable GetAllTestAppointmentFormated() 
        {
            string Query = "exec spGetAllAppointmentsFormated;";
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
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
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return dt;

        }
        public static DataTable GetAllTestApointmentForLocalDrivingLicense(int LocalDrivingLicenseApplicationID,int TestTypeID) 
        {
            string Query = @"exec spGetAllAppointmentsForTest @LocalDrivingLicenseApplicationID,@TestTypeID; ";

            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return dt;



        }
        public static bool UpdateTestAppointment(int TestAppointmentID,int TestTypeID,int LocalDrivingLiceseID,DateTime AppointmentDate,Decimal PaiedFees,int CreatedByUserID,bool IsLocked,int RetakeTestApplicationID) 
        {
string Query = @"exec spUpdateTestAppointment @TestAppointmentID, @TestTypeID, @localDrivingLicenseID, @AppointmentDate, @PaiedFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID;";
            bool Updated = false;
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@localDrivingLicenseID", LocalDrivingLiceseID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaiedFees", PaiedFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == -1) command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            try
            {
                Connection.Open();

                int  Rows = command.ExecuteNonQuery();
                Updated = (Rows > 0);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return Updated;


        }
        public static bool FindTestAppointmentByID(int TestAppointmentID,ref int TestTypeID, ref int LocalDrivingLiceseID, ref DateTime AppointmentDate, ref Decimal PaiedFees, ref int CreatedByUserID, ref bool IsLocked,ref int RetakeTestApplicationID) 
        {

            string Query = @"exec spGetTestAppointmentByID @TestAppointmentID;";

            bool Found = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    TestTypeID = (int)Reader["TestTypeID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    LocalDrivingLiceseID = (int) Reader["LocalDrivingLicenseApplicationID"];
                    PaiedFees = (Decimal)Reader["PaidFees"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    IsLocked = (bool)Reader["IsLocked"];
                    if (Reader["RetakeTestApplicationID"] == DBNull.Value) { RetakeTestApplicationID = -1; }
                    else RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"];
                    Found = true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Found;
        }
        public static int  AddTestAppointment(int TestTypeID,int LocalDrivingLicenseApplicationID,DateTime AppointmentDate, Decimal PaiedFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;
            string Query = @"exec spAddNewTestAppointment @TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID;";
          
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaiedFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == -1) command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID)) 
                {
                    TestAppointmentID = InsertedID;
                    
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return TestAppointmentID;


        }
        public static bool IsLocalDrivingLicenesAppointmentActive(int LocalDrivingLicenseApplicationID,int TestTypeID) 
        {
            string Query = @"exec spCheckActiveAppointmentForTest @LocalDrivingLicenseApplicationID,@TestTypeID ";

            bool IsActive = false;
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                IsActive = Reader.HasRows;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return IsActive;

        }
        public static int  GetCountOfFailedTestsForLDLATestType(int TestTypeID,int LocalDrivingLicenseApplicationID) 
        {
            int TotalFailedTest = 0;
            string Query = @"exec spGetNumberFailedTestsForTest  @TestTypeID , @LocalDrivingLicenseApplicationID ;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int failedTests))
                {
                    TotalFailedTest = failedTests;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return TotalFailedTest;
        }
        public static bool IsLocalDrivingLicneseAppointmentHasPassedTest(int LocalDrivingLicenseApplicationID, int TestTypeID) 
        {
            string Query = @"exec spCheckPassedTestAppointmentForTest  @LocalDrivingLicenseApplicationID  , @TestTypeID ;";

            bool IsActive = false;
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                IsActive = Reader.HasRows;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return IsActive;
        }

      
    }
}

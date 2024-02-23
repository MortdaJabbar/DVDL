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
    public class clsLocalDrivingLicenseData
    {
        public static DataTable GetAllLocalDrivingLicenses() 
        {
          
            DataTable LocalDrivingLicense = new DataTable();
           
            string query = "select * from LocalDrivingLicenseApplications;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                while (Reader != null)
                {
                    LocalDrivingLicense.Load(Reader);
                    Reader.Read();
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return LocalDrivingLicense;

        }
        public static DataTable GetAllLocalDrivingLicensesFormated()
        {

            DataTable LocalDrivingLicense = new DataTable();
            // Stored Procedure to get local driving License , You can Look at database 
            string query = @"exec spGetAllLocalDrinvingLicenseInfo;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                while (Reader != null)
                {
                    LocalDrivingLicense.Load(Reader);
                    Reader.Read();
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return LocalDrivingLicense;

        }
        public static bool UpdateLocalDrivingLicense(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            string query = @"update  LocalDrivingLicenseApplications 
                    set   LicenseClassID=@LicenseClassID,
                          ApplicationID=@ApplicationID
                    Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        public static int AddLocalDrivingLicense( int ApplicationID, int LicenseClassID)
        {
            string query = @"insert into LocalDrivingLicenseApplications 
                    values(@ApplicationID,@LicenseClassID); SELECT SCOPE_IDENTITY();";
            int  LocalDrivingLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
          
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result!=null && int.TryParse(Result.ToString(),out int InsertedID)) { LocalDrivingLicenseID = InsertedID; }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return LocalDrivingLicenseID;
        }
        public static bool FindLocalDrivingLicenseByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID,ref int LicenseClassID)
        {
            string query = @"Select * from  LocalDrivingLicenseApplications 
                    Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read() ) { Found = true; ApplicationID = (int)Reader["ApplicationID"]; LicenseClassID = (int)Reader["LicenseClassID"]; }
                Reader.Close();
            
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Found;

        }
        public static bool FindLocalDrivingLicenseByLiceseneClassIDAndPersonID(int LicenseClassID,int PersonID ,ref int LocalDrivingLicenseApplicationID, ref int ApplicationID)
        {
            string query = @"Select LocalDrivingLicenseApplicationID,Applications.ApplicationID,LicenseClassID from  LocalDrivingLicenseApplications inner Join Applications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
                    Where LicenseClassID = @LicenseClassID AND Applications.ApplicantPersonID = @PersonID;";
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read()) { Found = true; ApplicationID = (int)Reader["ApplicationID"]; LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"]; }
                Reader.Close();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return Found;

        }
        public static int GetCountOfPassedTestsForLDLA(int LocalDrivingLicenseApplicationID)
        {
            int TotalPassedTests = 0;
            string Query = @"exec spGetNumberOfPassedTestsForLDLA  @LocalDrivingLicenseApplicationID ;";

            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int PassedTests))
                {
                    TotalPassedTests = PassedTests;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return TotalPassedTests;


        }
        public static bool IsLocalDrivingLicenesApplicationExsist(int LocalDrivingLicenseApplicationID)
        {
            string Query = @"exec uspIsLDLAExsist @LocalDrivingLicenseApplicationID;";

            bool IsActive = false;
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
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
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID) 
        {
            string Query = @"Delete from LocalDrivingLicenseApplications  where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
 
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
        public static int GetActiveLicenseID(int LicenseClassID) 
        {
            int LicenseID = -1;
         string Query = @"select LicenseID from Licenses Where LicenseClass  = @LicenseClassID AND IsActive = 1";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    LicenseID = InsertedID;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return LicenseID;


        }


    }
}

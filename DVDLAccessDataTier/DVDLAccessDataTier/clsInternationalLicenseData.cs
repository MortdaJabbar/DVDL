using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DVDLAccessDataTier
{
    public class clsInternationalLicenseData
    {
    
        public static DataTable GetAllInternationalLicensesFormated()
        {
            DataTable dt = new DataTable();
            string Query = @"select InternationalLicenseID , ApplicationID , IssuedUsingLocalLicenseID as LocalLicenseID , IssueDate , ExpirationDate , IsActive from InternationalLicenses ;";
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
        public static bool FindInternationalLiceseByID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            string Query = @"exec uspFindInternationalLicense  @InternationalLicenseID;";
            bool Found = false;
        
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationID = Convert.ToInt32(Reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(Reader["DriverID"]);
                    IssueDate = Convert.ToDateTime(Reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(Reader["ExpirationDate"]);
                    IsActive = Convert.ToBoolean(Reader["IsActive"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    IssuedUsingLocalLicenseID = Convert.ToInt32(Reader["IssuedUsingLocalLicenseID"]);

                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindInternationalLiceseByLocalLicenseID(int IssuedUsingLocalLicenseID, ref int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            string Query = @"exec uspGet_International_License_By_Local_LicenseID   @LocalLicenseID;";
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@LocalLicenseID", IssuedUsingLocalLicenseID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationID = Convert.ToInt32(Reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(Reader["DriverID"]);
                    IssueDate = Convert.ToDateTime(Reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(Reader["ExpirationDate"]);
                    IsActive = Convert.ToBoolean(Reader["IsActive"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    InternationalLicenseID = Convert.ToInt32(Reader["InternationalLicenseID"]);

                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool UpdateInternationalLiceseByID(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            string Query = @"exec uspFindInternationalLicense  @InternationalLicenseID;";
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();

                int Rows = command.ExecuteNonQuery();
                
                    Found = Rows>0;
               
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static int  AddNewInternatioanlLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive,int CreatedByUserID)
        {
            string Query = @"Update InternationalLicenses set IsActive = 0 Where DriverID=@DriverID;    exec uspAddNewInternationalLicenes @ApplicationID , @DriverID , @LocalLicenseID , @IssueDate , @ExpirationDate ,@IsActive , @CreatedByUserID ;";
            int InternationalLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();
                if(Result!=null && int.TryParse(Result.ToString(),out int InsertedID)) 
                {
                    InternationalLicenseID = InsertedID;
                }
               
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return InternationalLicenseID;
        }
        public static bool DeleteInternationaLincese(int InternationalLicenseID) 
        {
            string Query = @"Delete from InternationalLicenses Where InternationalLicenseID = @InternationalLicenseID;";
            bool Deleted = false;

            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            try
            {
                Connection.Open();

                int Rows = command.ExecuteNonQuery();
                Deleted = Rows > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Deleted;
        }
        public static DataTable GetAllInternationalLicensesForPerson(int PersonID) 
        {
            DataTable dt = new DataTable();
            string Query = @"exec uspGet_All_International_License_For_Person @PersonID ;";
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
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return dt;


        }    
        public static bool IsInternationalLicenseExsist(int InternationalLicenseID)
        {
            string Query = @"exec uspIsInternationalLicenseExsist @InternationalLicenseID;";
            bool Found = false;

            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            try
            {
                Connection.Open();

                SqlDataReader  Reader= command.ExecuteReader();
                Found = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;

        }
        public static int GetActiveInternaionalLicenseID(int DriverID)
        {
            string Query = @"select top 1 InternaionalLicenseID from InternationalLicenses Where DriverID=@DriverID and GetDate() between IssueDate and ExpirationDate";
            int  InternaionalLiceseneID = - 1;

            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();
                if(Result!=null && int.TryParse(Result.ToString(),out int ActiveID)) 
                {
                    InternaionalLiceseneID = ActiveID;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return InternaionalLiceseneID;
        }

    }
}

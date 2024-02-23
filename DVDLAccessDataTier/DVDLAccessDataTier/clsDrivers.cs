using Microsoft.VisualBasic.ApplicationServices;
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
    public  class clsDrivers
    {
        public static DataTable GetAllDrivers()
        {
            DataTable Drivers = new DataTable();
            string query = "select * from Drivers;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Drivers.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return Drivers;

        }
        public static DataTable GetAllDriversFormated()
        {
            DataTable Drivers = new DataTable();
            string Query = @"exec uspGetAllDriverFormated;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader != null) 
                {
                    Drivers.Load(Reader);
                }
                
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return Drivers;


        }
        public static DataTable GetDriversCreatedByUserID(ref int DriverID,ref int PersonID,int UserID,ref DateTime CreateDate) 
        {
            DataTable Drivers = new DataTable();
            string query = @"select DriverID, Drivers.PersonID ,CreatedDate from Drivers 
                inner join Users on Users.UserID = Drivers.CreatedByUserID Where CreatedByUserID=@myUserID;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myUserID", UserID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Drivers.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }

            return Drivers;


        }
        public static bool FindDriverByID(int DriverID , ref int CreateByUserID,ref int PersonID,ref DateTime CreateDate )
        {
            bool Found = false;
            string query = "select * from Drivers where DriverID = @myDriverID";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myDriverID", DriverID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    CreateByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                    CreateDate = Convert.ToDateTime(Reader["CreatedDate"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindDriverByPersonID(int PersonID, ref int CreateByUserID, ref int DriverID, ref DateTime CreateDate)
        {
            bool Found = false;
            string query = "select * from Drivers where PersonID = @PersonID";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    CreateByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    DriverID = Convert.ToInt32(Reader["DriverID"]);
                    CreateDate = Convert.ToDateTime(Reader["CreatedDate"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static int AddDriver( int CreatedByUserID, int PersonID,  DateTime CreatedDate)
        {
            string query = @"insert into Drivers(CreatedByUserID,PersonID,CreatedDate)
                    values(@CreatedByUserID,@PersonID,@CreatedDate); Select Scope_identity();";
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            
            try
            {
                connection.Open();
                object  Result = command.ExecuteScalar();

                if (Result!=null && int.TryParse(Result.ToString(),out int Inserted)) { DriverID = Inserted; }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return DriverID;
        }
        public static bool UpdateDriver(int DriverID,int CreateByUserID, int PersonID, DateTime CreateDate)
        {
            string query = @"update Drivers 
                    set CreateByUserID=@CreateByUserID
                    , PersonID=@PersonID
                    , CreateDate=@CreateDate
                    Where DriverID = @DriverID";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreateByUserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreateDate", CreateDate);

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
        public static bool DeleteDriver(int DriverID)
        {
            bool Deleted = false;
            string query = @"DELETE FROM Drivers WHERE DriverID = @DriverID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
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
        public static bool IsDriverExsistByDriverID(int DriverID) 
        {
            bool Found = false;
            string query = "select Found=1 from Drivers  Where DriverID = @DriverID;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();
                Found = Result != null;
                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool IsDriverExsistByPersonID(int PersonID)
        {
            bool Found = false;
            string query = "select Found=1 from Drivers  Where PersonID = @PersonID;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();
                Found = Result != null;

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
    }
}

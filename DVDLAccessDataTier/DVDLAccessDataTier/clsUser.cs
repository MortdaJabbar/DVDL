using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVDLAccessDataTier
{
    public class clsUser
    {
        public static bool FindUserByUserID(int UserID , ref int PersonID,ref string UserName,ref string Password,ref bool isActive) 
        {
            bool Found = false;
            string query = "select * from Users  where UserID = @myUserID";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myUserID", UserID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                    UserName = Reader["UserName"].ToString();
                    Password = Reader["Password"].ToString();
                    isActive = Convert.ToBoolean(Reader["IsActive"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindUserByPersonID(ref int UserID,  int PersonID, ref string UserName, ref string Password, ref bool isActive)
        {
            bool Found = false;
            string query = @"select * from Users Where PersonID =@PersonID;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    UserID = Convert.ToInt32(Reader["UserID"]);
                    UserName = Reader["UserName"].ToString();
                    Password = Reader["Password"].ToString();
                    isActive = Convert.ToBoolean(Reader["IsActive"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindUserByUserNameAndPassword(ref int UserID,ref int PersonID , string UserName,string Password,ref bool isActive) 
        {
            bool Found = false;
            string query = "select * from Users  where UserName = @UserName And Password = @Password";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                    isActive = Convert.ToBoolean(Reader["IsActive"]);
                    UserID = Convert.ToInt32(Reader["UserID"]);
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static DataTable GetAllUsers()
        {
            string query = @"SELECT  Users.UserID, Users.PersonID,FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL( People.ThirdName,'') +' ' + People.LastName,Users.UserName, Users.IsActive  FROM  Users INNER JOIN People ON Users.PersonID = People.PersonID; ";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);

            SqlCommand Command = new SqlCommand(query, Connection);
            DataTable People = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
            
                while (Reader!=null)
                {
                    People.Load(Reader);
                    Reader.Read();
                }
                Reader.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Connection.Close();
            return People;
        }
        public static int AddUser(int PersonID, string UserName, string Password,  bool isActive)
        {
            string query = @"insert into Users (PersonID,UserName,Password,IsActive)
                    values(@PersonID,@UserName,@Password,@isActive); SELECT SCOPE_IDENTITY();";
            bool Added = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);

           int  UserID = -1;
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@isActive", isActive);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedUserId))
                {
                    UserID = InsertedUserId;
                }
            }
            catch (Exception e)
            { // log it
            }
            finally { connection.Close(); }

            return UserID;
        }
        public static bool UpdateUser(int UserID,int PersonID, string UserName, string Password, bool isActive)
        {
            string query = @"update Users 
                    set Password=@Password,
                     IsActive=@isActive,
                     PersonID=@PersonID,
                     UserName=@UserName
                    Where UserID = @UserID;";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserID", UserID);
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
        public static bool ChangePassword(string UserName ,string Password) 
        {
            string query = @"update Users 
                      set Password=@Password,
                      Where UserName=@UserName;";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
   
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
        public static bool DeleteUser(int UserID)
        {
            bool Deleted = false;
            string query = @"DELETE FROM Users WHERE UserID = @UserID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
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
        public static bool isUserExsistByUserID(int UserID) 
        {
            bool Found = false;
            string query = "select 'Found' from Users  Where UserID = @myUserID;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myUserID", UserID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                Found = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool isUserExsistByPersonID(int PersonID)
        {
            bool Found = false;
            string query = "select 'Found' from Users  Where PersonID = @myPersonID;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myPersonID", PersonID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                Found = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool isUserExsist(string UserName,string Password)
        {
            bool Found = false;
            string query = "select 'Found' from Users  Where UserName = @UserName And Password = @myPassword;";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@myPassword", Password);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                Found = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
   
    
    
    }
}

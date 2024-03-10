using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace DVDLAccessDataTier
{
    public class clsPeopleDataAccess
    {
        public static DataTable GetAllPeople()
        {
            string query = "select * from People Order by PersonID;";
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
                Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error);
                Console.WriteLine(ex.Message);
            }

            Connection.Close();
            return People;
        }
        public static bool FindPersonByFirstName(ref int personid, ref string NationalNo, string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            string query = "select * from People where FirstName = @myFirstName";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myFirstName", FirstName);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    personid = Convert.ToInt32(Reader["PersonID"]);
                    NationalNo = Reader["NationalNo"].ToString();
                    SecondName = Reader["SecondName"].ToString();

                    if (Reader["ThirdName"] == DBNull.Value) { ThirdName = ""; }
                    else { ThirdName = Reader["ThirdName"].ToString(); }

                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gender = Convert.ToByte(Reader["Gender"]);

                    if (Reader["Email"] == DBNull.Value) { Email = ""; }
                    else { Email = Reader["Email"].ToString(); }

                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);

                    if (Reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else { ImagePath = Reader["ImagePath"].ToString(); }

                    Found = true;
                }
                    Reader.Close();
                
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindPersonBySecondName(ref int personid, ref string NationalNo, ref string FirstName,  string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            string query = "select * from People where SecondName = @mySecondName";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@mySecondName", SecondName);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    personid = Convert.ToInt32(Reader["PersonID"]);
                    NationalNo = Reader["NationalNo"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    if (Reader["ThirdName"] != DBNull.Value) ThirdName = Reader["ThirdName"].ToString();
                    else ThirdName = "";
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gender = Convert.ToByte(Reader["Gender"]);
                    if (Reader["Email"] != DBNull.Value) Email = Reader["Email"].ToString();
                    else Email = "";
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    if (Reader["ImagePath"] != DBNull.Value) ImagePath = Reader["ImagePath"].ToString();
                    else ImagePath = "";
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindPersonByID( int personid, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            string query = "select * from People where PersonID = @myPersonID";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myPersonID", personid);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
              
                if (Reader.Read())
                {
                    Found = true;
                    NationalNo = Reader["NationalNo"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    if (Reader["ThirdName"] == DBNull.Value) { ThirdName = ""; }
                    else { ThirdName = Reader["ThirdName"].ToString(); }

                    LastName = Convert.ToString(Reader["LastName"]);
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gender = Convert.ToByte(Reader["Gender"]);

                    if (Reader["Email"] == DBNull.Value) { Email = ""; }
                    else { Email = Reader["Email"].ToString(); }

                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);

                    if (Reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else { ImagePath = Reader["ImagePath"].ToString(); }

                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message);}

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindPersonByThirdName(ref int personid, ref string NationalNo, ref string FirstName, ref string SecondName, string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            string query = "select * from People where ThirdName = @myThirdName";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myThirdName", ThirdName);
            try
            {
                Connection.Open();

       SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    personid = Convert.ToInt32(Reader["PersonID"]);
                    NationalNo = Reader["NationalNo"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gender = Convert.ToByte(Reader["Gender"]);

                    if (Reader["Email"] == DBNull.Value) { Email = ""; }
                    else { Email = Reader["Email"].ToString(); }
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    if (Reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else { ImagePath = Reader["ImagePath"].ToString(); }
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindPersonByFourthName(ref int personid, ref string NationalNo, ref string FirstName,ref string SecondName, ref string ThirdName,  string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            string query = "select * from People where LastName = @myFourthName";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myFourthName", ThirdName);
            try
            {
                Connection.Open();

       SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    personid = Convert.ToInt32(Reader["PersonID"]);
                    NationalNo = Reader["NationalNo"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    if (Reader["ThirdName"] != DBNull.Value) ThirdName = Reader["ThirdName"].ToString();
                    else ThirdName = "";
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gender = Convert.ToByte(Reader["Gender"]);
                    if (Reader["Email"] != DBNull.Value) ThirdName = Reader["Email"].ToString();
                    else Email = "";
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    if (Reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else { ImagePath = Reader["ImagePath"].ToString(); }
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindPersonByGender(ref int personid, ref string NationalNo, ref string FirstName,ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,  byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            string query = "select * from People where Gender = @myGender";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myGender", Gender);
            try
            {
                Connection.Open();

       SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    personid = Convert.ToInt32(Reader["PersonID"]);
                    NationalNo = Reader["NationalNo"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Email = Reader["Email"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    ImagePath = Reader["ImagePath"].ToString();
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindPersonByPhone(ref int personid, ref string NationalNo, ref string FirstName, string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            string query = "select * from People where Phone = @myPhone";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@myPhone", Phone);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    personid = Convert.ToInt32(Reader["PersonID"]);
                    NationalNo = Reader["NationalNo"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    if (Reader["ThirdName"] != DBNull.Value) ThirdName = Reader["ThirdName"].ToString();
                    else ThirdName = "";
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    if (Reader["Email"] != DBNull.Value) Email = Reader["Email"].ToString();
                    else Email = "";
                    Email = Reader["Email"].ToString();
                    Gender = Convert.ToByte(Reader["Gender"]);
                    Address = Reader["Address"].ToString();
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    if (Reader["ImagePath"] != DBNull.Value) ImagePath = Reader["ImagePath"].ToString();
                    else ImagePath = "";
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static bool FindPersonByEmail(ref int personid, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,ref  byte Gender, ref string Address, ref string Phone, string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            string query = "select * from People where Email = @Email";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@Email", Gender);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    personid = Convert.ToInt32(Reader["PersonID"]);
                    NationalNo = Reader["NationalNo"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    if (Reader["ThirdName"] != DBNull.Value) ThirdName = Reader["ThirdName"].ToString();
                    else ThirdName = "";
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    Gender = Convert.ToByte(Reader["Gender"]);
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    if (Reader["ImagePath"] != DBNull.Value) ThirdName = Reader["ImagePath"].ToString();
                    else ImagePath = "";
                    Found = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;
        }
        public static int AddPerson(string NationalNo,  string FirstName, string SecondName,  string ThirdName,  string LastName,  DateTime DateOfBirth, byte Gender,  string Address,  string Phone, string Email, int NationalityCountryID,  string ImagePath) 
        {
            int PersondID = -1;
       string query = @"insert into People(NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gender,Address,Phone,Email,NationalityCountryID,ImagePath)
                    values(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gender,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath)  Select Scope_identity();";
            
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            try
            {
                connection.Open();
                SqlDataReader Reader =command.ExecuteReader();
                if (Reader.Read()) { PersondID = Convert.ToInt32(Reader[0]); }

                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }
            finally { connection.Close();  }

            return PersondID;
        }
        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            string query = @"Update People 
                    set NationalNo=@NationalNo
                    , FirstName=@FirstName
                    , SecondName=@SecondName
                    , ThirdName=@ThirdName  
                    , LastName=@LastName
                    , DateOfBirth=@DateOfBirth
                    , Gender=@Gender
                    , Address=@Address
                    , Phone=@Phone  
                    , Email=@Email
                    , NationalityCountryID=@NationalityCountryID
                    , ImagePath=@ImagePath 
                    Where PersonID = @PersonID";
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
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
        public static bool DeletePerson(int PersonID) 
        {
            bool Deleted = false;
            string query = @"DELETE FROM People WHERE PersonID = @PersonID;";
            SqlConnection connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try 
            { 
                connection.Open(); 
                int row = command.ExecuteNonQuery();
                if (row > 0) { Deleted = true; } }
                catch (Exception ex){
                Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine($"{ex.Message}"); 
            }
            finally { connection.Close(); }
            return Deleted;
        }
        public static bool IsPersonExsist(int PersonID) 
        {
            bool Found = false;
            string query = "select * from People where PersonID = @myPersonID";
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
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;

        }
        public static bool IsPersonExsist(string NationalNo)
        {
            bool Found = false;
            string query = "select * from People where NationalNo = @NationalNo";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                Found = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;

        }
        public static bool FindPersonByNationalNo(string NationalNo , ref int Personid, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            string query = "select * from People where NationalNo = @NationalNo";
            SqlConnection Connection = new SqlConnection(clsAccessString.AccessString);
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read()) 
                {

                    Personid = (int)Reader["PersonID"];
                    SecondName = Reader["SecondName"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    if (Reader["ThirdName"] == DBNull.Value) { ThirdName = ""; }
                    else { ThirdName = Reader["ThirdName"].ToString(); }

                    LastName = Convert.ToString(Reader["LastName"]);
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gender = Convert.ToByte(Reader["Gender"]);

                    if (Reader["Email"] == DBNull.Value) { Email = ""; }
                    else { Email = Reader["Email"].ToString(); }

                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);

                    if (Reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else { ImagePath = Reader["ImagePath"].ToString(); }
                    Found = true;

                }


                Reader.Close();
            }
            catch (Exception ex) { Global.LogEvent("DVDL", $"{ex.Message}", EventLogEntryType.Error); Console.WriteLine(ex.Message); }

            finally { Connection.Close(); }
            return Found;

        }


    }


}


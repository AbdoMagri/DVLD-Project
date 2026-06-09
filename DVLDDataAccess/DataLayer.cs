using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsPersoneDataAccess
    {
        public static DataTable GetAllPeole()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from People";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleByID(string id)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from People where PersonID like @PersonID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", "%" + id + "%");

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleByNationalNo(string NationalNo)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo LIKE '%' + @NationalNo + '%' ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleByFirstName(string FirstName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE FirstName LIKE '%' + @FirstName + '%' ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleBySecondName(string Name)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE SecondName LIKE '%' + @Name + '%' ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleByThirdName(string Name)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE ThirdName LIKE '%' + @Name + '%' ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleByLastName(string Name)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE LastName LIKE '%' + @Name + '%' ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleByGender(char Gender)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE Gender = @Gender ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Gender", Gender);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleByPhone(string Phone)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE Phone Like @Phone ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Phone","%" + Phone + "%");

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleByEmail(string Email)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE Email like @Email ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", "%" + Email + "%");

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetPeoleByNationality(string CountryID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalityCountryID like @Nationality ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nationality","%" + CountryID + "%");

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName,string NationalNo,char Gender ,string Email, string Phone, string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People(FirstName,SecondName,ThirdName,LastName,NationalNo,Gender,Email,Phone,Address,DateOfBirth,NationalityCountryID,ImagePath) 
                VALUES(@FirstName, @SecondName, @ThirdName, @LastName ,@NationalNo,@Gender,@Email ,@Phone,@Address ,@DateOfBirth,@CountryID, @ImagePath);
                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gender", Gender);
            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID)) { PersonID = insertedID; }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }
            return PersonID;
        }

        public static bool UpdatePersone(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, char Gender, string Email, string Phone, string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE People SET 
                    FirstName = @FirstName,
                    SecondName = @SecondName,
                    ThirdName = @ThirdName,
                    LastName = @LastName,
                    NationalNo = @NationalNo,
                    Gender = @Gender,
                    Email = @Email,
                    Phone = @Phone,
                    Address = @Address,
                    DateOfBirth = @DateOfBirth,
                    NationalityCountryID  = @CountryID,
                    ImagePath = @ImagePath
                WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally { connection.Close(); }
            return RowAffected > 0;
        }

        public static bool GetPersonInfoByID(int ID, ref string FirstName,ref string SecondName, ref string ThirdName, ref string LastName,ref string NationalNo,ref char Gender, ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth,
            ref int CountryID, ref string ImagePath)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "";
                    LastName = (string)reader["LastName"];
                    NationalNo = (string)reader["NationalNo"];
                    Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                    Gender = reader["Gender"] != DBNull.Value ? ((string)reader["Gender"])[0] : ' ';
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else ImagePath = "";
                }
                else isFound = false;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetPersonInfoByNationalNo(ref int ID, ref string FirstName,ref string SecondName, ref string ThirdName, ref string LastName, string NationalNo,ref char Gender, ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth,
            ref int CountryID, ref string ImagePath)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "";
                    LastName = (string)reader["LastName"];
                    ID = (int)reader["PersonID"];
                    Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                    Gender = reader["Gender"] != DBNull.Value ? ((string)reader["Gender"])[0] : ' ';
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else ImagePath = "";
                }
                else isFound = false;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool IsPersonExist(string NationalNo)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select found = 1 from People where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                found = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return found;
        }

        public static bool DeletePerson(int ID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete From People 
                WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally { connection.Close(); }
            return RowAffected > 0;
        }
    }
}

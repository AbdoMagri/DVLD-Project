using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsUserData
    {

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT       Users.UserID, Users.PersonID,FullName = People.FirstName + ' ' +  People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName, Users.IsActive
FROM            Users INNER JOIN
                         People ON Users.PersonID = People.PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }

        public static bool FindByUserNameAndPassword(string userName, string password, ref int PersonID, ref int Id,ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * from Users where UserName = @UserName  and Password =  @Password ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    Id = (int)reader["UserID"];
                    IsActive = (bool)reader["IsActive"];
                }
                reader.Close();

            }
            catch (Exception ex) {
                return isFound;
            }
            finally { connection.Close(); }
            return isFound;
        }
        public static bool Find(int ID, ref int PersonID,ref string UserName, ref string Password,ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * from Users where UserID = @ID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                reader.Close();

            }
            catch (Exception ex) {
                return isFound;
            }
            finally { connection.Close(); }
            return isFound;
        }
        public static int AddNewUser(int PersonID,string UserName, string Password, bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users(PersonID,UserName,Password,IsActive) 
                VALUES(@PersonID, @UserName, @Password, @IsActive );
                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID)) { UserID = insertedID; }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }
            return UserID;
        }
        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Users SET 
                    UserName = @UserName,
                    Password = @Password,
                    IsActive = @IsActive,
                WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

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
        public static bool IsUserExist(int PersonID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select found = 1 from Users where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                found = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
            return found;
        }
    }
}

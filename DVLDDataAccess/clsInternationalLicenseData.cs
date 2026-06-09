using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccess
{
    public class clsInternationalLicenseData
    {
        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID FROM InternationalLicenses";
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

        public static bool Find(int ID, ref int ApplicationID, ref int DriverID,
            ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
            ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                return isFound;
            }
            finally { connection.Close(); }

            return isFound;
        }

        public static int AddNewInternationalLicense(int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    InternationalLicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }

            return InternationalLicenseID;
        }

        public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID,
            int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE InternationalLicenses SET
                    ApplicationID             = @ApplicationID,
                    DriverID                  = @DriverID,
                    IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                    IssueDate                 = @IssueDate,
                    ExpirationDate            = @ExpirationDate,
                    IsActive                  = @IsActive,
                    CreatedByUserID           = @CreatedByUserID
                WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
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
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally { connection.Close(); }

            return rowsAffected > 0;
        }

        public static bool IsInternationalLicenseExist(int InternationalLicenseID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT found = 1 FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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
        public static bool IsInternationalLicenseExistWithLicneseID(int LicenseID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT found = 1 FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
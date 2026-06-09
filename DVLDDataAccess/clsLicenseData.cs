using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccess
{
    public class clsLicenseData
    {
        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID FROM Licenses";
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
        public static DataTable GetSpecificLicenses(int DriverID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT LicenseID, ApplicationID,  LicenseClass =  LicenseClasses.ClassName , IssueDate, ExpirationDate, IsActive from Licenses inner join LicenseClasses on Licenses.LicenseClass = LicenseClasses.LicenseClassID where Licenses.DriverID = @DriverID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

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
            ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref string Notes, ref decimal PaidFees, ref bool IsActive,
            ref int IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Licenses WHERE LicenseID = @ID";
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
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];
                    PaidFees = Convert.ToDecimal(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = Convert.ToInt32(reader["IssueReason"]);
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
        public static bool FindByDriverID(ref int ID, ref int ApplicationID,  int DriverID,
            ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref string Notes, ref decimal PaidFees, ref bool IsActive,
            ref int IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Licenses WHERE DriverID = @DriverID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    ID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];
                    PaidFees = Convert.ToDecimal(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = Convert.ToInt32(reader["IssueReason"]);
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

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees,
            bool IsActive, int IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }

            return LicenseID;
        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID,
            int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes,
            decimal PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Licenses SET
                    ApplicationID   = @ApplicationID,
                    DriverID        = @DriverID,
                    LicenseClass    = @LicenseClass,
                    IssueDate       = @IssueDate,
                    ExpirationDate  = @ExpirationDate,
                    Notes           = @Notes,
                    PaidFees        = @PaidFees,
                    IsActive        = @IsActive,
                    IssueReason     = @IssueReason,
                    CreatedByUserID = @CreatedByUserID
                WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        public static bool IsLicenseExist(int LicenseID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT found = 1 FROM Licenses WHERE LicenseID = @LicenseID";
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
        public static bool IsLicneseExistByPersonIDAndClass(int DriverID, int LicenseClassID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select top 1 found = 1 from Licenses where DriverID = @DriverID and LicenseClass = @LicenseClassID and IsActive = 1 ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        public static bool IsLicenseExistAndActiveAndNotEnded(int LicenseID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT found = 1 FROM Licenses 
                     WHERE LicenseID = @LicenseID 
                     AND IsActive = 1 
                     AND ExpirationDate >= GETDATE()
                     AND LicenseClass = 3";

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
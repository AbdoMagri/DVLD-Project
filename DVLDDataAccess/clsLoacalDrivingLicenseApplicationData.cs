using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsLocalDrivingLicenseApplicationData
    {
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID FROM LocalDrivingLicenseApplications";
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

        public static bool Find(int ID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @ID";
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
                    LicenseClassID = (int)reader["LicenseClassID"];
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
        public static bool FindByAppID(ref int ID,  int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
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

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                VALUES (@ApplicationID, @LicenseClassID);
                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LocalDrivingLicenseApplicationID = insertedID;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }

            return LocalDrivingLicenseApplicationID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,
            int ApplicationID, int LicenseClassID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE LocalDrivingLicenseApplications SET
                    ApplicationID  = @ApplicationID,
                    LicenseClassID = @LicenseClassID
                WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static bool IsLocalDrivingLicenseApplicationExist(int LocalDrivingLicenseApplicationID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT found = 1 FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
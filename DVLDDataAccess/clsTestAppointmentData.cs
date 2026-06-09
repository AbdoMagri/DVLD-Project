using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsTestAppointmentData
    {
        public static DataTable GetAllTestAppointments()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked FROM TestAppointments";
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
        public static bool IsTestAppointmentExist(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT found = 1 FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID and IsLocked = 0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static bool IsTestAppointmentExistsAndFaild(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT    found = 1    FROM            LocalDrivingLicenseApplications INNER JOIN                   TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN                      Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestAppointments.TestTypeID = @TestTypeID and Tests.TestResult = 0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
        public static bool IsTestAppointmentExistsAndPassed(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT    found = 1    FROM            LocalDrivingLicenseApplications INNER JOIN                   TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN                      Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestAppointments.TestTypeID = @TestTypeID and Tests.TestResult = 1";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
        public static DataTable GetAllAppointmentsForSomeOneByLDLAppID(int Id, int TestTypeID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked FROM TestAppointments where LocalDrivingLicenseApplicationID = @Id and TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
        

        public static bool Find(int ID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,
            ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
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

        public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            int TestAppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked)
                VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked);
                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }

            return TestAppointmentID;
        }

        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID,
            int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments SET
                    TestTypeID                       = @TestTypeID,
                    LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                    AppointmentDate                  = @AppointmentDate,
                    PaidFees                         = @PaidFees,
                    CreatedByUserID                  = @CreatedByUserID,
                    IsLocked                         = @IsLocked
                WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

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

        public static bool IsTestAppointmentExist(int TestAppointmentID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT found = 1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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
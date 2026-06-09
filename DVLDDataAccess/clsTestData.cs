using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsTestData
    {
        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID FROM Tests";
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

        public static bool Find(int ID, ref int TestAppointmentID, ref bool TestResult,
            ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests WHERE TestID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    Notes = (string)reader["Notes"];
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

        public static int AddNewTest(int TestAppointmentID, bool TestResult,
            string Notes, int CreatedByUserID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }

            return TestID;
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult,
            string Notes, int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Tests SET
                    TestAppointmentID = @TestAppointmentID,
                    TestResult        = @TestResult,
                    Notes             = @Notes,
                    CreatedByUserID   = @CreatedByUserID
                WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
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

        public static bool IsTestExist(int TestID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT found = 1 FROM Tests WHERE TestID = @TestID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);

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

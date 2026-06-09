using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsTestTypeData
    {
        public static DataTable GetTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select ID = TestTypeID, Title = TestTypeTitle,Description = TestTypeDescription, Fess = TestTypeFees from TestTypes";
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

        public static bool UpdateTestType(int ID, string Title, string Description, double Fees)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestTypes SET 
            TestTypeTitle = @Title,
            TestTypeFees = @Fees,
            TestTypeDescription = @Description
        WHERE TestTypeID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@ID", ID);

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

        public static bool GetTestTypeByID(int ID, ref string Title, ref string Description, ref double Fees)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from TestTypes where TestTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Title = (string)reader["TestTypeTitle"];
                    Fees = Convert.ToDouble(reader["TestTypeFees"]);
                    Description = (string)reader["TestTypeDescription"];
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
    }
}

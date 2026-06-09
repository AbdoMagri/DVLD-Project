using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsApplicationTypesData
    {
        public static DataTable GetApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select ID = ApplicationTypeID, Title = ApplicationTypeTitle, Fess = ApplicationFees from ApplicationTypes";
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

        public static bool UpdateAppType(int ID, string Title, double Fees)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE ApplicationTypes SET 
                    ApplicationTypeTitle = @Title,
                    ApplicationFees = @Fees
                WHERE ApplicationTypeID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);
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

        public static bool GetAppTypeByID(int ID, ref string Title, ref double Fees)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from ApplicationTypes where ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Title = (string)reader["ApplicationTypeTitle"];
                    Fees = Convert.ToDouble(reader["ApplicationFees"]);
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

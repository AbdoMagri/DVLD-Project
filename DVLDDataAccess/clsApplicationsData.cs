using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsApplicationsData
    {

        public static bool Find(int ID, ref int ApplicantPersonID, ref DateTime ApplicationDate,
    ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime LastStatusDate,
    ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Applications WHERE ApplicationID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = Convert.ToInt32(reader["ApplicationStatus"]);
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToDecimal(reader["PaidFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
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
        public static int AddNewLocalDrivingLicense(int PersonID, DateTime? Date, int  ApplicationTypeID,int ApplicationStatus, DateTime? LastStatusDate, double PaidFees, int UserID,int LicenseClassID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications
           (ApplicantPersonID
           ,ApplicationDate
           ,ApplicationTypeID
           ,ApplicationStatus
           ,LastStatusDate
           ,PaidFees
           ,CreatedByUserID
           )
     VALUES
           (@PersonID
           ,@Date
           ,@ApplicationTypeID
           ,@ApplicationStatus
           ,@LastStatusDate
           ,@PaidFees
           ,@UserID
           );
                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@UserID", UserID);
            
            

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID)) { ApplicationID = insertedID;
                    _ConnectToLocalDrivingApplication(ApplicationID, LicenseClassID);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }
            return ApplicationID;
        }
        public static int AddNewApplication(int PersonID, DateTime? Date, int  ApplicationTypeID,int ApplicationStatus, DateTime? LastStatusDate, double PaidFees, int UserID,int LicenseClassID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications
           (ApplicantPersonID
           ,ApplicationDate
           ,ApplicationTypeID
           ,ApplicationStatus
           ,LastStatusDate
           ,PaidFees
           ,CreatedByUserID
           )
     VALUES
           (@PersonID
           ,@Date
           ,@ApplicationTypeID
           ,@ApplicationStatus
           ,@LastStatusDate
           ,@PaidFees
           ,@UserID
           );
                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@UserID", UserID);
            
            

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID)) { ApplicationID = insertedID;}

            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }
            return ApplicationID;
        }

        private static bool _ConnectToLocalDrivingApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications
           (ApplicationID
           ,LicenseClassID)
     VALUES
           (@ApplicationID,
           @LicenseClassID
           );
                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            



            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID)) { LocalDrivingApplicationID = insertedID; }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }
            return LocalDrivingApplicationID == -1;
        }

        public static bool IsApplicationExist(int PersonID, int LicenseClassID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select top 1 found = 1    FROM            Applications INNER JOIN                      LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID where ApplicantPersonID = 1026 and LicenseClassID = 1 and ApplicationStatus in (1,2) ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID  AS [L.D.L.AppID],
    LicenseClasses.ClassName                                           AS [Driving Class],
    People.NationalNo                                                  AS [National No.],
    CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName) AS [Full Name],
    Applications.ApplicationDate                                       AS [Application Date],
    ((SELECT COUNT(*) 
     FROM Tests
     INNER JOIN TestAppointments 
         ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
     WHERE Tests.TestResult = 1 
       AND TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID))
	
	AS [Passed Tests],
    Applications.ApplicationStatus                                     AS [Status]

FROM Applications
    INNER JOIN LocalDrivingLicenseApplications
        ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
    INNER JOIN LicenseClasses
        ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
    INNER JOIN People
        ON Applications.ApplicantPersonID = People.PersonID";
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
        public static bool CancelApplication(int ApplicationID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Applications SET 
                    ApplicationStatus = 3
                WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            

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
        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
    int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate,
    double PaidFees, int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Applications SET
            ApplicantPersonID = @ApplicantPersonID,
            ApplicationDate   = @ApplicationDate,
            ApplicationTypeID = @ApplicationTypeID,
            ApplicationStatus = @ApplicationStatus,
            LastStatusDate    = @LastStatusDate,
            PaidFees          = @PaidFees,
            CreatedByUserID   = @CreatedByUserID
        WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
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
    }
}

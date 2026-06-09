using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsTestAppointment
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }

        public clsTestAppointment()
        {
            TestAppointmentID = 0;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
            Mode = enMode.AddNew;
        }

        public clsTestAppointment(int testAppointmentID, int testTypeID,
            int localDrivingLicenseApplicationID, DateTime appointmentDate,
            decimal paidFees, int createdByUserID, bool isLocked)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            Mode = enMode.Update;
        }

        public static clsTestAppointment Find(int ID)
        {
            int testTypeID = 0;
            int localDrivingLicenseApplicationID = 0;
            DateTime appointmentDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = 0;
            bool isLocked = false;

            if (clsTestAppointmentData.Find(ID, ref testTypeID, ref localDrivingLicenseApplicationID,
                ref appointmentDate, ref paidFees, ref createdByUserID, ref isLocked))
            {
                return new clsTestAppointment(ID, testTypeID, localDrivingLicenseApplicationID,
                    appointmentDate, paidFees, createdByUserID, isLocked);
            }
            return null;
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentData.GetAllTestAppointments();
        }
        public static bool IsTestAppointmentExists(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentData.IsTestAppointmentExist(LocalDrivingLicenseApplicationID, TestTypeID);
        }
        public static bool IsTestAppointmentExistsAndFaild(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentData.IsTestAppointmentExistsAndFaild(LocalDrivingLicenseApplicationID, TestTypeID);
        }
        public static bool IsTestAppointmentExistsAndPassed(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentData.IsTestAppointmentExistsAndPassed(LocalDrivingLicenseApplicationID, TestTypeID);
        }
        public static DataTable GetAllAppointmentsForSomeOneByLDLAppID(int Id, int TestTypeID)
        {
            return clsTestAppointmentData.GetAllAppointmentsForSomeOneByLDLAppID(Id, TestTypeID);
        }

        public static bool IsTestAppointmentExists(int id)
        {
            return clsTestAppointmentData.IsTestAppointmentExist(id);
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment(
                this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);

            return this.TestAppointmentID != -1;
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateTestAppointment(
                this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }

        public bool Save()
        {
            try
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewTestAppointment())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;

                    case enMode.Update:
                        return _UpdateTestAppointment();
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }
    }
}
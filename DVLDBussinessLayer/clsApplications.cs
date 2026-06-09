using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsApplications
    {
        public int Id { get; set; }
        public int ApplicationPersonID { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public int ApplictationStatus { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int LicenseClassID { get; set; }
        enum enStatus { enNew = 1, enCompleted = 2, enCanceled = 3}
        public clsApplications()
        {
            Id = -1;
            ApplicationPersonID = -1;
            ApplicationDate = null;
            ApplicationTypeID = -1;
            LastStatusDate = null;
            PaidFees = -1;
            CreatedByUserID = -1;
            LicenseClassID = -1;
        }

        private clsApplications(int id, int applicationPersonID, DateTime? applicationDate,
    int applicationTypeID, int applictationStatus, DateTime? lastStatusDate,
    double paidFees, int createdByUserID, int licenseClassID)
        {
            Id = id;
            ApplicationPersonID = applicationPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplictationStatus = applictationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            LicenseClassID = licenseClassID;
        }

        public static clsApplications Find(int ID)
        {
            int applicantPersonID = -1;
            DateTime applicationDate = DateTime.Now;
            int applicationTypeID = -1;
            int applicationStatus = -1;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = -1;
            int createdByUserID = -1;

            if (clsApplicationsData.Find(ID, ref applicantPersonID, ref applicationDate,
                ref applicationTypeID, ref applicationStatus, ref lastStatusDate,
                ref paidFees, ref createdByUserID))
            {
                return new clsApplications(ID, applicantPersonID, applicationDate,
                    applicationTypeID, applicationStatus, lastStatusDate,
                    (double)paidFees, createdByUserID, -1);
            }
            return null;
        }

        public bool AddNewLoacalDrivingLicense()
        {
                this.Id = clsApplicationsData.AddNewLocalDrivingLicense(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplictationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID, this.LicenseClassID);
                return this.Id != -1; 
        }
        public bool AddNewApplication()
        {
                this.Id = clsApplicationsData.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplictationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID, this.LicenseClassID);
                return this.Id != -1; 
        }

        public static bool IsAppExist(int PersonID, int LicenseClassID)
        {
            return clsApplicationsData.IsApplicationExist(PersonID, LicenseClassID);
        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsApplicationsData.GetAllLocalDrivingLicenseApplications();
        }

        public static bool CancelApplication(int ApplicatonID)
        {
            return clsApplicationsData.CancelApplication(ApplicatonID);
        }
        public bool _UpdateApplication()
        {
            return clsApplicationsData.UpdateApplication(
                this.Id, this.ApplicationPersonID, this.ApplicationDate.Value,
                this.ApplicationTypeID, this.ApplictationStatus,
                this.LastStatusDate.Value, this.PaidFees, this.CreatedByUserID);
        }
    }
}

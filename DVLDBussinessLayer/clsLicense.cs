using DVLDDataAccess;
using System;
using System.Data;

namespace DVLDBussinessLayer
{
    public class clsLicense
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicense()
        {
            LicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            LicenseClass = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = 0;
            IsActive = true;
            IssueReason = 0;
            CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }

        public clsLicense(int licenseID, int applicationID, int driverID, int licenseClass,
            DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees,
            bool isActive, int issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        public static clsLicense Find(int ID)
        {
            int applicationID = 0;
            int driverID = 0;
            int licenseClass = 0;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string notes = "";
            decimal paidFees = 0;
            bool isActive = false;
            int issueReason = 0;
            int createdByUserID = 0;

            if (clsLicenseData.Find(ID, ref applicationID, ref driverID, ref licenseClass,
                ref issueDate, ref expirationDate, ref notes, ref paidFees,
                ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicense(ID, applicationID, driverID, licenseClass,
                    issueDate, expirationDate, notes, paidFees,
                    isActive, issueReason, createdByUserID);
            }
            return null;
        }
        public static clsLicense FindByDriverID(int driverID)
        {
            int applicationID = 0;
            int ID = 0;
            int licenseClass = 0;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string notes = "";
            decimal paidFees = 0;
            bool isActive = false;
            int issueReason = 0;
            int createdByUserID = 0;

            if (clsLicenseData.FindByDriverID(ref ID, ref applicationID,  driverID, ref licenseClass,
                ref issueDate, ref expirationDate, ref notes, ref paidFees,
                ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicense(ID, applicationID, driverID, licenseClass,
                    issueDate, expirationDate, notes, paidFees,
                    isActive, issueReason, createdByUserID);
            }
            return null;
        }

        public static DataTable GetAllLicenses()
        {
            return clsLicenseData.GetAllLicenses();
        }
        public static DataTable GetSpecificLicenses(int DriverID)
        {
            return clsLicenseData.GetSpecificLicenses(DriverID);
        }

        public static bool IsLicenseExists(int id)
        {
            return clsLicenseData.IsLicenseExist(id);
        }

        public static bool IsLicneseExistByPersonIDAndClass(int DriverId, int LicneseClassID)
        {
            return clsLicenseData.IsLicneseExistByPersonIDAndClass(DriverId, LicneseClassID);
        }

        public static bool IsLicenseExistAndActiveAndNotEnded(int licenseID)
        {
            return clsLicenseData.IsLicenseExistAndActiveAndNotEnded(licenseID);
        }



        private bool _AddNewLicense()
        {
            try
            {
            this.LicenseID = clsLicenseData.AddNewLicense(
                this.ApplicationID, this.DriverID, this.LicenseClass,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
                this.IsActive, this.IssueReason, this.CreatedByUserID);

            return this.LicenseID != -1;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private bool _UpdateLicense()
        {
            return clsLicenseData.UpdateLicense(
                this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
                this.IsActive, this.IssueReason, this.CreatedByUserID);
        }

        public bool Save()
        {
            try
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewLicense())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;

                    case enMode.Update:
                        return _UpdateLicense();
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
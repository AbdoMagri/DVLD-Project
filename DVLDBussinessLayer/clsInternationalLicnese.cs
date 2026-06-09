using DVLDDataAccess;
using System;
using System.Data;

namespace DVLDBussinessLayer
{
    public class clsInternationalLicense
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicense()
        {
            InternationalLicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            IssuedUsingLocalLicenseID = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now.AddYears(1);
            IsActive = true;
            CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }

        public clsInternationalLicense(int internationalLicenseID, int applicationID,
            int driverID, int issuedUsingLocalLicenseID, DateTime issueDate,
            DateTime expirationDate, bool isActive, int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        public static clsInternationalLicense Find(int ID)
        {
            int applicationID = 0;
            int driverID = 0;
            int issuedUsingLocalLicenseID = 0;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            bool isActive = false;
            int createdByUserID = 0;

            if (clsInternationalLicenseData.Find(ID, ref applicationID, ref driverID,
                ref issuedUsingLocalLicenseID, ref issueDate, ref expirationDate,
                ref isActive, ref createdByUserID))
            {
                return new clsInternationalLicense(ID, applicationID, driverID,
                    issuedUsingLocalLicenseID, issueDate, expirationDate,
                    isActive, createdByUserID);
            }
            return null;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public static bool IsInternationalLicenseExists(int id)
        {
            return clsInternationalLicenseData.IsInternationalLicenseExist(id);
        }
        public static bool IsInternationalLicenseExistWithLicneseID(int id)
        {
            return clsInternationalLicenseData.IsInternationalLicenseExistWithLicneseID(id);
        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(
                this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return this.InternationalLicenseID != -1;
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(
                this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate,
                this.IsActive, this.CreatedByUserID);
        }

        public bool Save()
        {
            try
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewInternationalLicense())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;

                    case enMode.Update:
                        return _UpdateInternationalLicense();
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
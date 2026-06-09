using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsLocalDrivingLicenseApplication
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = 0;
            ApplicationID = 0;
            LicenseClassID = 0;
            Mode = enMode.AddNew;
        }

        public clsLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID,
            int applicationID, int licenseClassID)
        {
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            ApplicationID = applicationID;
            LicenseClassID = licenseClassID;
            Mode = enMode.Update;
        }

        public static clsLocalDrivingLicenseApplication Find(int ID)
        {
            int applicationID = 0;
            int licenseClassID = 0;

            if (clsLocalDrivingLicenseApplicationData.Find(ID, ref applicationID, ref licenseClassID))
            {
                return new clsLocalDrivingLicenseApplication(ID, applicationID, licenseClassID);
            }
            return null;
        }
        public static clsLocalDrivingLicenseApplication FindByAppID(int AppID)
        {
            int ID = 0;
            int licenseClassID = 0;

            if (clsLocalDrivingLicenseApplicationData.FindByAppID(ref ID,  AppID, ref licenseClassID))
            {
                return new clsLocalDrivingLicenseApplication(ID, AppID, licenseClassID);
            }
            return null;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        }

        public static bool IsLocalDrivingLicenseApplicationExists(int id)
        {
            return clsLocalDrivingLicenseApplicationData.IsLocalDrivingLicenseApplicationExist(id);
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID =
                clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(
                    this.ApplicationID, this.LicenseClassID);

            return this.LocalDrivingLicenseApplicationID != -1;
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(
                this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        public bool Save()
        {
            try
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewLocalDrivingLicenseApplication())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;

                    case enMode.Update:
                        return _UpdateLocalDrivingLicenseApplication();
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
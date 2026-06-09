using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsLicenseClass
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        public clsLicenseClass()
        {
            LicenseClassID = 0;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;
            Mode = enMode.AddNew;
        }

        public clsLicenseClass(int licenseClassID, string className, string classDescription,
            byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {
            LicenseClassID = licenseClassID;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            ClassFees = classFees;
            Mode = enMode.Update;
        }

        public static clsLicenseClass Find(int ID)
        {
            string className = "";
            string classDescription = "";
            byte minimumAllowedAge = 0;
            byte defaultValidityLength = 0;
            decimal classFees = 0;

            if (clsLicenseClassData.Find(ID, ref className, ref classDescription,
                ref minimumAllowedAge, ref defaultValidityLength, ref classFees))
            {
                return new clsLicenseClass(ID, className, classDescription,
                    minimumAllowedAge, defaultValidityLength, classFees);
            }
            return null;
        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassData.GetAllLicenseClasses();
        }

        public static bool IsLicenseClassExists(int id)
        {
            return clsLicenseClassData.IsLicenseClassExist(id);
        }

        private bool _AddNewLicenseClass()
        {
            this.LicenseClassID = clsLicenseClassData.AddNewLicenseClass(
                this.ClassName, this.ClassDescription,
                this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);

            return this.LicenseClassID != -1;
        }

        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassData.UpdateLicenseClass(
                this.LicenseClassID, this.ClassName, this.ClassDescription,
                this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }

        public bool Save()
        {
            try
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewLicenseClass())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;

                    case enMode.Update:
                        return _UpdateLicenseClass();
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
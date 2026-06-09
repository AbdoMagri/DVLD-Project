using DVLDDataAccess;
using System;
using System.Data;

namespace DVLDBussinessLayer
{
    public class clsDriver
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriver()
        {
            DriverID = 0;
            PersonID = 0;
            CreatedByUserID = 0;
            CreatedDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        public clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
            Mode = enMode.Update;
        }

        public static clsDriver Find(int ID)
        {
            int personID = 0;
            int createdByUserID = 0;
            DateTime createdDate = DateTime.Now;

            if (clsDriverData.Find(ID, ref personID, ref createdByUserID, ref createdDate))
            {
                return new clsDriver(ID, personID, createdByUserID, createdDate);
            }
            return null;
        }

        public static clsDriver FindByPersonID(int PersonID)
        {
            int driverID = 0;
            int createdByUserID = 0;
            DateTime createdDate = DateTime.Now;

            if (clsDriverData.FindByPersonID(PersonID, ref driverID, ref createdByUserID, ref createdDate))
            {
                return new clsDriver(driverID, PersonID, createdByUserID, createdDate);
            }
            return null;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDrivers();
        }

        public static bool IsDriverExists(int id)
        {
            return clsDriverData.IsDriverExist(id);
        }

        public static bool IsDriverExistsByPersonID(int personID)
        {
            return clsDriverData.IsDriverExistByPersonID(personID);
        }

        private bool _AddNewDriver()
        {
            try
            {
            this.DriverID = clsDriverData.AddNewDriver(
                this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return this.DriverID != -1;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(
                this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }

        public bool Save()
        {
            try
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewDriver())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;

                    case enMode.Update:
                        return _UpdateDriver();
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
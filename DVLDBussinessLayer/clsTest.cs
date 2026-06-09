using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsTest
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTest()
        {
            TestID = 0;
            TestAppointmentID = 0;
            TestResult = false;
            Notes = "";
            CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }

        public clsTest(int testID, int testAppointmentID, bool testResult,
            string notes, int createdByUserID)
        {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        public static clsTest Find(int ID)
        {
            int testAppointmentID = 0;
            bool testResult = false;
            string notes = "";
            int createdByUserID = 0;

            if (clsTestData.Find(ID, ref testAppointmentID, ref testResult,
                ref notes, ref createdByUserID))
            {
                return new clsTest(ID, testAppointmentID, testResult, notes, createdByUserID);
            }
            return null;
        }

        public static DataTable GetAllTests()
        {
            return clsTestData.GetAllTests();
        }

        public static bool IsTestExists(int id)
        {
            return clsTestData.IsTestExist(id);
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestData.AddNewTest(
                this.TestAppointmentID, this.TestResult,
                this.Notes, this.CreatedByUserID);

            return this.TestID != -1;
        }

        private bool _UpdateTest()
        {
            return clsTestData.UpdateTest(
                this.TestID, this.TestAppointmentID,
                this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public bool Save()
        {
            try
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewTest())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;

                    case enMode.Update:
                        return _UpdateTest();
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

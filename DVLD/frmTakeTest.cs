using DVLD.Properties;
using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmTakeTest : Form
    {
        //public frmTakeTest(int loacalDrivingAppID, int enTestType)
        //{
        //    InitializeComponent();
        //    _LoacalDrivingAppID = loacalDrivingAppID;
        //    _LoacalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(loacalDrivingAppID);
        //    _enTest = (enTestType)enTestType;
        //}
        public frmTakeTest(int loacalDrivingAppID, int TestAppointmentID, int enTestType)
        {
            InitializeComponent();
            _LoacalDrivingAppID = loacalDrivingAppID;
            _LoacalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(loacalDrivingAppID);
            _TestAppointmentId = TestAppointmentID;
            if (_TestAppointmentId != -1) { _Appointment = clsTestAppointment.Find(_TestAppointmentId); }
            _enTest = (enTestType)enTestType;
            if (enTestType == 1)
            {
                pannel1.Image = Resources.Vision_512;
                grpTest.Text = "Vision Test";
            }
            else if (enTestType == 2)
            {
                pannel1.Image = Resources.Written_Test_32;
                grpTest.Text = "Written Test";
            }
            else
            {
                pannel1.Image = Resources.Street_Test_32;
                grpTest.Text = "Street Test";
            }
        }



        enum enTestType { enVision = 1, enWritten = 2, enStreet = 3 }
        private enTestType _enTest;

        private int _TestAppointmentId = -1;
        private int _LoacalDrivingAppID;
        private clsLocalDrivingLicenseApplication _LoacalDrivingLicenseApplication;
        private clsTestAppointment _Appointment = new clsTestAppointment();
        private clsTest _Test = new clsTest();

        private void _LoadData()
        {
            lblDLAppID.Text = _LoacalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = clsLicenseClass.Find(_LoacalDrivingLicenseApplication.LicenseClassID).ClassName.ToString();
            lblName.Text = clsPerson.Find(clsApplications.Find(_LoacalDrivingLicenseApplication.ApplicationID).ApplicationPersonID).FullName.ToString();
            lblTrial.Text = "0";
            dtpDate.Value = _Appointment.AppointmentDate;
            dtpDate.Enabled = false;
            lblFees.Text = _Appointment.PaidFees.ToString();

        }

        private void _FillTestObject(ref clsTest _Test)
        {
            _Test.CreatedByUserID = clsGlobal.CurrentUser.Id;
            _Test.Notes = txtNote.Text.ToString();
            _Test.TestAppointmentID = _Appointment.TestAppointmentID;
            _Test.TestResult = rpFail.Checked ? false : true;
        }



        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _Appointment = clsTestAppointment.Find(_TestAppointmentId);
            _Appointment.IsLocked = true;
            _FillTestObject(ref _Test);
            if (_Appointment.Save())
            {
                if (_Test.Save())
                {

                    MessageBox.Show("Data saved Seccessfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error Saving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error Saving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}

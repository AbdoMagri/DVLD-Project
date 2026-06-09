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
    public partial class frmScheduleTest : Form
    {
        public frmScheduleTest(int loacalDrivingAppID, int enTestType, bool Retake)
        {
            InitializeComponent();
            _LoacalDrivingAppID = loacalDrivingAppID;
            _LoacalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(loacalDrivingAppID);
            _enTest = (enTestType)enTestType;
            _Retake = Retake;
            if (enTestType == 1)
            {
                panel1.Image = Resources.Vision_512;
                grpTest.Text = "Vision Test";
            }
            else if (enTestType == 2)
            {
                panel1.Image = Resources.Written_Test_32;
                grpTest.Text = "Written Test";
            }
            else
            {
                panel1.Image = Resources.Street_Test_32;
                grpTest.Text = "Street Test";
            }
        }
        public frmScheduleTest(int loacalDrivingAppID, int TestAppointmentID, int enTestType, bool islocked, bool Retake)
        {
            InitializeComponent();
            _LoacalDrivingAppID = loacalDrivingAppID;
            _LoacalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(loacalDrivingAppID);
            _TestAppointmentId = TestAppointmentID;
            if (_TestAppointmentId != -1) {_Appointment = clsTestAppointment.Find(_TestAppointmentId); }
            _enTest = (enTestType)enTestType;
            _isLocked = islocked;
            _Retake = Retake;
            if (enTestType == 1)
            {
                panel1.Image = Resources.Vision_512;
                grpTest.Text = "Vision Test";
            }
            else if (enTestType == 2)
            {
                panel1.Image = Resources.Written_Test_32;
                grpTest.Text = "Written Test";
            }
            else
            {
                panel1.Image = Resources.Street_Test_32;
                grpTest.Text = "Street Test";
            }
        }
        enum enTestType { enVision = 1, enWritten = 2, enStreet = 3 }
        private enTestType _enTest;

        private bool _isLocked= false;
        private bool _Retake = false;
        private int _TestAppointmentId = -1;
        private int _LoacalDrivingAppID;
        private clsLocalDrivingLicenseApplication _LoacalDrivingLicenseApplication;
        private clsTestAppointment _Appointment =  new clsTestAppointment();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            if (_isLocked)
            {
                grpTest.Enabled = false;
                lblAppointmentIsLocked.Visible = true;
            }
            else if (_Retake)
            {
                lblTitle.Text = "Schedule Retake Test";
                grpRetake.Enabled = true;
                lblRAppFees.Text = "5";
            }
            lblDLAppID.Text = _LoacalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = clsLicenseClass.Find(_LoacalDrivingLicenseApplication.LicenseClassID).ClassName;
            lblName.Text = clsPerson.Find(clsApplications.Find(_LoacalDrivingLicenseApplication.ApplicationID).ApplicationPersonID).FullName;
            dtpDate.MinDate = DateTime.Now.Date;
            lblFees.Text = clsTestType.Find((int)_enTest).Fees.ToString();
            lblTotalFees.Text = (double.Parse(lblFees.Text) + double.Parse(lblRAppFees.Text)).ToString();
            if (_TestAppointmentId != -1)
            {
                dtpDate.Value = clsTestAppointment.Find(_TestAppointmentId).AppointmentDate;
            }
        }

        private void _FillAppointmentObject(ref clsTestAppointment _Appointment)
        {
            _Appointment.AppointmentDate = dtpDate.Value.Date;
            _Appointment.TestTypeID = (int)_enTest;
            _Appointment.LocalDrivingLicenseApplicationID = _LoacalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            _Appointment.PaidFees = int.Parse(lblTotalFees.Text);
            _Appointment.CreatedByUserID = clsGlobal.CurrentUser.Id;
            _Appointment.IsLocked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillAppointmentObject(ref _Appointment);
            if (_Appointment.Save())
            {
                MessageBox.Show("Data saved Seccessfully", "success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Saving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }


    }
}

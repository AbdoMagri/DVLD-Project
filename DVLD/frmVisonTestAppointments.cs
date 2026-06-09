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
    public partial class frmVisonTestAppointments : Form
    {
        public frmVisonTestAppointments(int BaseAppID, int LocalDrivingLicenseAppID, int enTestType)
        {
            InitializeComponent();
            _BaseAppID = BaseAppID;
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            _enTest = (enTestType)enTestType;
            if (enTestType == 1)
            {
                panel1.BackgroundImage = Resources.Vision_512;
                this.Text = "Vision Test Appointments";
            }
            else if (enTestType == 2) {
                panel1.BackgroundImage = Resources.Written_Test_32;
                this.Text = "Written Test Appointments";
            }
            else
            {
                panel1.BackgroundImage = Resources.Street_Test_32;
                this.Text = "Street Test Appointments";
            }
        }

        enum enTestType { enVision = 1, enWritten = 2, enStreet = 3 }

        private enTestType _enTest;
        private int _BaseAppID;
        private int _LocalDrivingLicenseAppID;

        private void _RefreshData()
        {
            dgvAppointments.DataSource = clsTestAppointment.GetAllAppointmentsForSomeOneByLDLAppID(int.Parse(ctrlDrivingLicenseApplicationInfo1.id), (int)_enTest);
        }
        public static void ShowApplicationInfo(int ApplicationID)
        {
            clsApplications app = clsApplications.Find(ApplicationID);

            if (app == null)
            {
                MessageBox.Show("Application not found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                $"Application ID     : {app.Id}\n" +
                $"Applicant Person ID: {app.ApplicationPersonID}\n" +
                $"Application Date   : {app.ApplicationDate?.ToString("yyyy-MM-dd")}\n" +
                $"Application Type ID: {app.ApplicationTypeID}\n" +
                $"Status             : {app.ApplictationStatus}\n" +
                $"Last Status Date   : {app.LastStatusDate?.ToString("yyyy-MM-dd")}\n" +
                $"Paid Fees          : {app.PaidFees}\n" +
                $"Created By User ID : {app.CreatedByUserID}",
                "Application Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void frmVisonTestAppointments_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadData(_BaseAppID, _LocalDrivingLicenseAppID);
            //ShowApplicationInfo(_BaseAppID);
            _RefreshData();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseAppID = int.Parse(ctrlDrivingLicenseApplicationInfo1.id);
            int testType = (int)_enTest;

            // 1 - has active appointment already
            if (clsTestAppointment.IsTestAppointmentExists(localDrivingLicenseAppID, testType))
            {
                MessageBox.Show("Person already has an active appointment for this test, you cannot add a new appointment",
                    "Cannot Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2 - already passed
            if (clsTestAppointment.IsTestAppointmentExistsAndPassed(localDrivingLicenseAppID, testType))
            {
                MessageBox.Show("Person already passed this test, you cannot add a new appointment",
                    "Cannot Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3 - previously failed → allow retake
            bool hasFailed = clsTestAppointment.IsTestAppointmentExistsAndFaild(localDrivingLicenseAppID, testType);

            frmScheduleTest frm = new frmScheduleTest(localDrivingLicenseAppID, testType, hasFailed);
            frm.ShowDialog();
            _RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            
            frmScheduleTest frm = new frmScheduleTest(int.Parse(ctrlDrivingLicenseApplicationInfo1.id), (int)dgvAppointments.CurrentRow.Cells[0].Value, (int)_enTest, (bool)dgvAppointments.CurrentRow.Cells[3].Value, clsTestAppointment.IsTestAppointmentExistsAndFaild(int.Parse(ctrlDrivingLicenseApplicationInfo1.id), (int)_enTest));
            frm.ShowDialog();
            _RefreshData();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((bool)dgvAppointments.CurrentRow.Cells[3].Value)
            {
                MessageBox.Show("This Test is locked", "Locked test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmTakeTest frm = new frmTakeTest(int.Parse(ctrlDrivingLicenseApplicationInfo1.id), (int)dgvAppointments.CurrentRow.Cells[0].Value, (int)_enTest);
            frm.ShowDialog();
            _RefreshData();
        }
    }
}

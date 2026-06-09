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
    public partial class frmLocalDrivingLicenseApplictions : Form
    {
        public frmLocalDrivingLicenseApplictions()
        {
            InitializeComponent();
        }
        enum enTestType { enVision = 1, enWritten = 2 , enStreet = 3}
        private void _RefreshData()
        {
            dgvLocalDrivingLicenses.DataSource = clsApplications.GetAllLocalDrivingLicenseApplications();
            lblRecords.Text = (dgvLocalDrivingLicenses.RowCount - 1).ToString();
        }

        private clsLocalDrivingLicenseApplication _LDLApp = new clsLocalDrivingLicenseApplication();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseApplictions_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicense frm = new frmNewLocalDrivingLicense();
            frm.ShowDialog();
            _RefreshData();
        }

        private void tsmCancelApp_Click(object sender, EventArgs e)
        {
            clsApplications.CancelApplication((int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value);
            _RefreshData() ;
        }

        private void TSMScheduleVisionTest_Click(object sender, EventArgs e)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find((int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value);
            frmVisonTestAppointments frm = new frmVisonTestAppointments(_LDLApp.ApplicationID, (int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value , (int)enTestType.enVision);
            frm.ShowDialog();
            _RefreshData();
        }

        private void TSMScheduleWriteTest_Click(object sender, EventArgs e)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find((int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value);
            frmVisonTestAppointments frm = new frmVisonTestAppointments(_LDLApp.ApplicationID, (int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value, (int)enTestType.enWritten);
            frm.ShowDialog();
            _RefreshData();
        }

        private void TSMScheduleStreetTest_Click(object sender, EventArgs e)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find((int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value);
            frmVisonTestAppointments frm = new frmVisonTestAppointments(_LDLApp.ApplicationID, (int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value, (int)enTestType.enStreet);
            frm.ShowDialog();
            _RefreshData();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find((int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value);
            frmIssueDriverLicense frm = new frmIssueDriverLicense(_LDLApp.LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            _RefreshData();

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find((int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value);
            frmLicenseHistory frm = new frmLicenseHistory(clsApplications.Find(_LDLApp.ApplicationID).ApplicationPersonID);
            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo((int)dgvLocalDrivingLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}

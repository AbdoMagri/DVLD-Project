using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBussinessLayer;

namespace DVLD
{
    public partial class Form1 : Form
    {
        private clsUser _CurrentUser;
        public Form1(clsUser currentUser)
        {
            InitializeComponent();
            _CurrentUser = currentUser;
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManagePeople frm = new frmManagePeople();
            frm.ShowDialog();
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            cmsAccountSettings.Show();
        }

        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void tsmManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void tsmManageTestTypes_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicense frm = new frmNewLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplictions frm  = new frmLocalDrivingLicenseApplictions();
            frm.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            frmDrivers frm = new frmDrivers();
            frm.ShowDialog();

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInernationalLicenseApp frm = new frmNewInernationalLicenseApp();
            frm.ShowDialog();
        }
    }
}

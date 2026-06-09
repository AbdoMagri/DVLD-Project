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
    public partial class frmIssueDriverLicense : Form
    {
        public frmIssueDriverLicense(int LDLAppID)
        {
            InitializeComponent();
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
        }

        private clsLocalDrivingLicenseApplication _LDLApp = new clsLocalDrivingLicenseApplication();
        private clsLicense _License = new clsLicense();
        private clsDriver _Driver = new clsDriver();
        
        private void _LoadData()
        {
            ctrlDrivingLicenseApplicationInfo1.LoadData(_LDLApp.ApplicationID, _LDLApp.LocalDrivingLicenseApplicationID);
        }

        private void _FillLicenseObject(ref clsLicense License, clsLocalDrivingLicenseApplication LDLApp) 
        {
            clsLicenseClass LicenseClass = clsLicenseClass.Find(LDLApp.LicenseClassID);
            License.ApplicationID = _LDLApp.ApplicationID;
            License.DriverID = _Driver.DriverID;
            License.ApplicationID = LDLApp.ApplicationID;
            License.LicenseClass = LDLApp.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = License.IssueDate.AddYears(LicenseClass.DefaultValidityLength);
            License.Notes = textBox1.Text.ToString();
            License.PaidFees = LicenseClass.ClassFees;
            License.IsActive = true;
            License.IssueReason = 1;
            License.CreatedByUserID = clsGlobal.CurrentUser.Id;

        }

        private void _FillDriverObject(ref clsDriver _Driver, clsLocalDrivingLicenseApplication _LDLApp)
        {
            clsApplications _App = clsApplications.Find(_LDLApp.ApplicationID);
            if (clsDriver.IsDriverExistsByPersonID(_App.ApplicationPersonID)) 
            {
                _Driver = clsDriver.FindByPersonID(_App.ApplicationPersonID);
                return;
            }
            _Driver.PersonID = _App.ApplicationPersonID;
            _Driver.CreatedDate = DateTime.Now;
            _Driver.CreatedByUserID = clsGlobal.CurrentUser.Id;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillDriverObject(ref _Driver, _LDLApp);
            _FillLicenseObject(ref _License, _LDLApp);
            clsApplications _App = clsApplications.Find(_LDLApp.ApplicationID);
            _App.ApplictationStatus = 2;
            if (_Driver.Save() && _License.Save())
            {
                MessageBox.Show("License issued Successfully with licese ID = 25", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _App._UpdateApplication();
            }


        }

        private void frmIssueDriverLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }


    }
}

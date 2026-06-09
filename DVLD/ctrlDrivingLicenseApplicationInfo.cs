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
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private clsApplications _Application = null;
        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication = null;
        public string id { get { return (lblDLDrivingID.Text.ToString()) ; } }



        private void _FillDrivingLicenseApplicationInfo(ref clsLocalDrivingLicenseApplication _localDrivingLicenseApplication)
        {
            lblDLDrivingID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = clsLicenseClass.Find(_localDrivingLicenseApplication.LicenseClassID).ClassName;
            lblPassedTests.Text = "0/3";

        }

        private void _FillApplicationBasicInfo(ref clsApplications _Application)
        {
            lblID.Text = _Application.Id.ToString();
            lblStatus.Text = _Application.ApplictationStatus == 1 ? "new" : _Application.ApplictationStatus == 2 ? "completed" : "canceled";
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = clsApplicationTypes.GetAppTypeByID(_Application.ApplicationTypeID).Title.ToString();
            lblApplicant.Text = clsPerson.Find(_Application.ApplicationPersonID).FullName;
            lblDate.Text = _Application.ApplicationDate.ToString();
            lblStatusDate.Text = _Application.LastStatusDate.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        public void LoadData(int BasicApplicationID, int LocalDrivingLicenseAppID)
        {
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseAppID);
            _Application = clsApplications.Find(BasicApplicationID);
            if (_Application != null && _localDrivingLicenseApplication != null) { 
                _FillApplicationBasicInfo(ref _Application);
                _FillDrivingLicenseApplicationInfo(ref _localDrivingLicenseApplication);
            }
            else
            {
                MessageBox.Show("Didnt find Application with ID:" + _Application.Id, "Invalid Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

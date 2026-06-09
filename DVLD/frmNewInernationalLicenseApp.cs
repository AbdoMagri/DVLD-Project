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
    public partial class frmNewInernationalLicenseApp : Form
    {
        public frmNewInernationalLicenseApp()
        {
            InitializeComponent();
        }

        private clsLicense _DriverLicense = new clsLicense();
        private clsInternationalLicense _InternationalLicense = new clsInternationalLicense();
        private clsApplications _Application = new clsApplications();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillInternationalLicneseObject(ref clsInternationalLicense _InternationalLicense)
        {
            _InternationalLicense.ApplicationID = _Application.Id;
            _InternationalLicense.DriverID = _DriverLicense.DriverID;
            _InternationalLicense.IssuedUsingLocalLicenseID = _DriverLicense.LicenseID;
            _InternationalLicense.IssueDate = DateTime.Now;
            _InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            _InternationalLicense.IsActive = true;
            _InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.Id;
        }

        private void _FillApplicationObject(ref clsApplications _Application)
        {
            _Application.ApplicationPersonID = clsDriver.Find(_DriverLicense.DriverID).PersonID;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = 6;
            _Application.ApplictationStatus = 1;
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaidFees = clsApplicationTypes.GetAppTypeByID(6).Fees;
            _Application.CreatedByUserID = clsGlobal.CurrentUser.Id;
        }
        private void frmNewInernationalLicenseApp_MouseHover(object sender, EventArgs e)
        {
            if (ctrlFilterDriverLicense1.searchClicked)
            {
                btnIssue.Enabled = true;
                lblLDLID.Text = ctrlFilterDriverLicense1.LDLID.ToString();
                _DriverLicense = clsLicense.Find(int.Parse(ctrlFilterDriverLicense1.LDLID.ToString()));
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            _FillApplicationObject(ref _Application);
            if (_Application.AddNewApplication())
            {
                _FillInternationalLicneseObject(ref _InternationalLicense);
                if (_InternationalLicense.Save())
                {
                    MessageBox.Show("Data saved Successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblILAppID.Text = _Application.Id.ToString();
                    lblILLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
                }
            }
        }

        private void frmNewInernationalLicenseApp_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblIssueDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblExpairationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }
    }
}

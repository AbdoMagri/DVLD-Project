using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int LDLAppID)
        {
            clsLocalDrivingLicenseApplication _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            clsApplications _App = clsApplications.Find(_LDLApp.ApplicationID);
            clsPerson _Person = clsPerson.Find(_App.ApplicationPersonID);
            clsLicense _License = clsLicense.FindByDriverID(clsDriver.FindByPersonID(_Person.Id).DriverID);
            lblClass.Text = clsLicenseClass.Find(_LDLApp.LicenseClassID).ClassName;
            lblName.Text = _Person.FullName;
            lblLID.Text = _License.LicenseID.ToString();
            lblNationalNo.Text = _Person.NationalNo.ToString();
            lblGender.Text = _Person.Gender.ToString();
            lblIssueDate.Text = _License.IssueDate.ToString("yyy-MM-dd");
            lblIssueReason.Text = _License.IssueReason == 1 ? "First Time" : _License.IssueReason == 2 ? "Renew" : _License.IssueReason == 3 ? "Replacement for Damaged" : "Replacement for Lost";
            lblNotes.Text = _License.Notes == null ? "No Notes" : _License.Notes.ToString();
            lblActive.Text = _License.IsActive ? "Yes" : "No";
            lblBirthDay.Text = _Person.DateOfBirth.ToString("yyy-MM-dd");
            lblDriverID.Text = _License.DriverID.ToString();
            lblExpirationDate.Text = _License.ExpirationDate.ToString("yyy-MM-dd");
            pictureBox1.Image = (_Person.ImagePath == null || !File.Exists(_Person.ImagePath))? null: Image.FromFile(_Person.ImagePath);
        }
    }
}

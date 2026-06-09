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
    public partial class frmNewLocalDrivingLicense : Form
    {
        public frmNewLocalDrivingLicense()
        {
            InitializeComponent();
        }
        clsPerson _Person;
        clsApplications _LocalDrivingLicense;
        int _PersonID;
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FillDrivingLicenseObject()
        {
            _LocalDrivingLicense = new clsApplications();
            _LocalDrivingLicense.ApplicationPersonID = _Person.Id;
            _LocalDrivingLicense.ApplicationDate = DateTime.Now;
            _LocalDrivingLicense.ApplicationTypeID = 1;
            _LocalDrivingLicense.ApplictationStatus = 1;
            _LocalDrivingLicense.LastStatusDate = DateTime.Now;
            _LocalDrivingLicense.PaidFees = 15;
            _LocalDrivingLicense.CreatedByUserID = clsGlobal.CurrentUser.Id;
            _LocalDrivingLicense.LicenseClassID = comboBox1.SelectedIndex + 1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillDrivingLicenseObject();
            if (clsLicense.IsLicneseExistByPersonIDAndClass(clsDriver.FindByPersonID(_LocalDrivingLicense.ApplicationPersonID).DriverID, clsLicenseClass.Find(comboBox1.SelectedIndex + 1).LicenseClassID))
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have a License for the selected class ",
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                
            }
            else if (clsApplications.IsAppExist(_LocalDrivingLicense.ApplicationPersonID, _LocalDrivingLicense.LicenseClassID))
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class ",
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (_LocalDrivingLicense.AddNewLoacalDrivingLicense())
                    {
                        MessageBox.Show("Driving License Added successfully");
                        lblApplicationID.Text = _LocalDrivingLicense.Id.ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            if (ctrlFilterPerson1.id == "[???]")
            {
                MessageBox.Show("Please Fill the person info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int.TryParse(ctrlFilterPerson1.id, out int id);
            _PersonID = id;
            _Person = clsPerson.Find(id);
            tabControl1.SelectedIndex = 1;
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM//yyyy");
            lblCreater.Text = _Person.FullName;
            comboBox1.SelectedIndex = 0;
        }


    }
}

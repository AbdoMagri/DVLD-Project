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
    public partial class ctrlFilterDriverLicense : UserControl
    {
        public ctrlFilterDriverLicense()
        {
            InitializeComponent();
            searchClicked = false;
        }
        public int LDLID { get; set; }

        public bool searchClicked { get; set; }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLicenseID.Text, out int licenseID))
            {
                ctrlDriverLicenseInfo1.LoadData(clsLocalDrivingLicenseApplication.FindByAppID(clsLicense.Find(licenseID).ApplicationID).LocalDrivingLicenseApplicationID);
            }
            else
            {
                MessageBox.Show("Please enter a valid License ID", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LDLID = int.Parse(txtLicenseID.Text);
            if (!clsLicense.IsLicenseExistAndActiveAndNotEnded(int.Parse(txtLicenseID.Text))) 
                {
                MessageBox.Show("not found an exist licnese with this id");
                return;
            }
            if (clsInternationalLicense.IsInternationalLicenseExistWithLicneseID(int.Parse(txtLicenseID.Text)))
            {
                MessageBox.Show("this person already have international licnese", "not allow");
                return;
            }
            searchClicked = true;
        }
    }
}

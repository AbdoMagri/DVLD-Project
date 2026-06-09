using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonInformation : UserControl
    {
        private clsPerson Person;
        public ctrlPersonInformation()
        {
            InitializeComponent();
        }

        private void _FillInformations()
        {
            lblID.Text = Person.Id.ToString();
            lblName.Text = Person.FullName.ToString();
            lblNationalNo.Text = Person.NationalNo.ToString();
            if (char.ToLower(Person.Gender) == 'm')
            {
                pbGender.Image = Properties.Resources.mars;
                lblGender.Text = "Male";
            }
            else
            {
                pbGender.Image = Properties.Resources.venus;
                lblGender.Text = "Female";
            }
            lblEmail.Text = Person.Email.ToString();
            lblAddress.Text = Person.Address.ToString();
            lblDateOfBirth.Text = Person.DateOfBirth.ToString();
            lblPhone.Text = Person.Phone.ToString();
            lblCountry.Text = clsCountry.Find(Person.CountryID).CountryName.ToString();
            if (!string.IsNullOrEmpty(Person.ImagePath) && File.Exists(Person.ImagePath))
            {
                pbPersonImage.Image = Image.FromFile(Person.ImagePath);
                btnEdit.Enabled = true;
                btnEdit.Visible = true;
            }
            else
            {
                pbPersonImage.Image = null;
            }
        }

        public void LoadInfo(int id)
        {
            Person = clsPerson.Find(id);
            if (Person != null)
            {
                _FillInformations();
            }
            else
            {
                MessageBox.Show("Didnt find Person with ID:" + id.ToString(), "Invalid Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEditPersonInfo frm = new frmAddEditPersonInfo(Person.Id);
            frm.ShowDialog();

        }
    }
}
using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class frmAddEditPersonInfo : Form
    {
        public frmAddEditPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = (_PersonID == -1) ? enMode.AddNew : enMode.Update;
        }

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPerson _Person;

        private string ImagePath = "";
        private string _newImagePath = "", _originalImagePath = "";
        private bool _imageChanged = false;
        private bool _imageRemoved = false;


        private void frmAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            _LoadData();
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNational.Text))
            {
                e.Cancel = true;
                txtNational.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtNational, $"{txtNational.Tag} is required");
            }
            else if (clsPerson.IsPersonExist(txtNational.Text.ToString()))
            {
                e.Cancel = true;
                txtNational.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtNational, $"NationalNo is already exist");
            }
            else
            {
                txtNational.BackColor = Color.White;
                errorProvider1.SetError(txtNational, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtPhone, $"{txtPhone.Tag} is required");
            }
            else if (!txtPhone.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                txtPhone.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtPhone, "Phone Number must contain digits only");
            }
            else
            {
                txtPhone.BackColor = Color.White;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtRequired_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.BackColor = Color.LightCoral;
                errorProvider1.SetError(txt, $"{txt.Tag} is required");
            }
            else
            {
                txt.BackColor = Color.White;
                errorProvider1.SetError(txt, "");
            }
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow dr in dt.Rows)
            {
                cbCountry.Items.Add(dr["CountryName"]);
            }
        }

        private void _LoadData()
        {
            _FillCountriesInComboBox();
            cbCountry.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Person";
                _Person = new clsPerson();
                return;
            }
            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because no Cntact with " + _PersonID.ToString());
                this.Close();
            }
            lblMode.Text = "Edit Contac ID = " + _PersonID;
            lblID.Text = _PersonID.ToString();
            txtFirst.Text = _Person.FirstName;
            txtSecond.Text = _Person.SecondName;
            txtThird.Text = _Person.ThirdName;
            txtLast.Text = _Person.LastName;
            txtNational.Text = _Person.NationalNo;
            ImagePath = _Person.ImagePath;
            
            if (_Person.ImagePath == "")
            {
                pbImage.Image = null;
            }
            else
            {
                pbImage.Image = Image.FromFile(_Person.ImagePath);
                btnRemove.Visible = true;
                btnRemove.Enabled = true;
            }
            if (_Person.Gender == 'm' || _Person.Gender == 'M')
            {
                rbMale.Checked = true;
            }
            else rbFemale.Checked = true;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbCountry.SelectedIndex = _Person.CountryID - 1;
            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetImage()
        {

            ofdSetImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofdSetImage.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = ofdSetImage.FileName;
                string extension = Path.GetExtension(sourcePath);
                string destPath = @"E:\coding\Road-Map\course_19\DVLD Images\" + Guid.NewGuid() + extension;

                _originalImagePath = sourcePath;
                _newImagePath = destPath;
                _imageChanged = true;
                _imageRemoved = false;

                // just display it, don't copy yet
                pbImage.Image?.Dispose();
                pbImage.Image = Image.FromFile(sourcePath);

                btnRemove.Enabled = true;
                btnRemove.Visible = true;
            }
        }
         private void _DeletePreviousImage()
        {

        }

        private void _RemoveImage()
        {
            if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
            {
                pbImage.Image?.Dispose();
                pbImage.Image = null;

                _imageChanged = false;
                _imageRemoved = true;
                _originalImagePath = "";
                _newImagePath = "";

                btnRemove.Enabled = false;
                btnRemove.Visible = false;

            }
                
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            _SetImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirst.Text) ||
        string.IsNullOrWhiteSpace(txtSecond.Text) ||
        string.IsNullOrWhiteSpace(txtLast.Text) ||
        string.IsNullOrWhiteSpace(txtAddress.Text) ||
        string.IsNullOrWhiteSpace(txtNational.Text) ||
        string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            // Handle image logic
            if (_imageRemoved)
            {
                // delete old image from disk
                if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                    File.Delete(_Person.ImagePath);
                _Person.ImagePath = "";
            }
            else if (_imageChanged)
            {
                // delete old image from disk
                if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                    File.Delete(_Person.ImagePath);

                // copy new image to destination
                File.Copy(_originalImagePath, _newImagePath);
                _Person.ImagePath = _newImagePath;
            }

            int CountryID = clsCountry.Find(cbCountry.Text).ID;
            _Person.FirstName = txtFirst.Text;
            _Person.SecondName = txtSecond.Text;
            _Person.ThirdName = string.IsNullOrWhiteSpace(txtThird.Text) ? "" : txtThird.Text;
            _Person.LastName = txtLast.Text;
            _Person.NationalNo = txtNational.Text;
            _Person.Email = txtEmail.Text;
            _Person.Gender = rbMale.Checked ? 'M' : 'F';
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.CountryID = CountryID;

            try
            {
                if (_Person.Save())
                {
                    _imageChanged = false;
                    _imageRemoved = false;
                    _Mode = enMode.Update;
                    _PersonID = _Person.Id;
                    lblMode.Text = "Edit Person ID = " + _PersonID;
                    lblID.Text = _PersonID.ToString();
                    MessageBox.Show("Data Saved Successfully.");
                }
                else MessageBox.Show("Error: Data Is not saved Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) return;
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                e.Cancel = true;
                txtEmail.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtEmail, "Enter a valid email address");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _RemoveImage();
            btnRemove.Enabled = false;
            btnRemove.Visible = false;
        }
    }
}

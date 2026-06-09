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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class AddUpdateUser : Form
    {
        public AddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = (_UserID == -1) ? enMode.AddNew : enMode.Update;
        }
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _UserID;
        clsUser _User = null;

        private void _LoadData()
        {
            

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New User";
                _User = new clsUser();
                return;
            }
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("This form will be closed because no Cntact with " + _UserID.ToString());
                this.Close();
            }
            tabControl1.SelectedIndex = 1;
            lblMode.Text = "Edit Contac ID = " + _UserID;
            lblID.Text = _UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;



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
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                txtConfirmPassword.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtConfirmPassword, $"{txtConfirmPassword.Tag} is required");
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                txtConfirmPassword.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtConfirmPassword, $"Password confirmation Doesnt mutch password");
            }
            else
            {
                txtConfirmPassword.BackColor = Color.White;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
        string.IsNullOrWhiteSpace(txtPassword.Text) ||
        string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            if (int.TryParse(ctrlFilterPerson1.id, out int id))
            {
                _User.PersonID = id;
            }
            _User.IsActive = chkIsActive.Checked;


                try
                {
                if (_User.Save())
                {
                    
                    _Mode = enMode.Update;
                    _UserID = _User.Id;
                    lblMode.Text = "Edit User ID = " + _UserID;
                    lblID.Text = _UserID.ToString();
                    MessageBox.Show("Data Saved Successfully.");
                }
                else MessageBox.Show("Error: Data Is not saved Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddUpdateUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (ctrlFilterPerson1.id == "[???]")
            {
                MessageBox.Show("Please Fill the person info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(ctrlFilterPerson1.id, out int id))
            {
                if (clsUser.IsUserExists(id))
                {
                MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }
            tabControl1.SelectedIndex = 1;
        }

    }
}

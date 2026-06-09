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
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void _HideTxtFilter ()
        {
                txtFilter.Visible = false;
                txtFilter.Enabled = false;
        }
        private void _ShowTxtFilter ()
        {
            if (cbFilter.SelectedItem != "None")
            {
                txtFilter.Visible = true;
                txtFilter.Enabled = true;
            }
            else _HideTxtFilter();
        }
        private void _ReturnAllPeopleWhenFilterIsEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                dgvPeople.DataSource = clsPerson.GetAllPeople();
            }
        }
        private void _refreshPeople()
        {
            string selected = cbFilter.SelectedItem.ToString();
            switch (selected)
            {
                case "Person ID":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    if (int.TryParse(txtFilter.Text, out int id))
                    {
                        dgvPeople.DataSource = clsPerson.GetPeoplebyID(txtFilter.Text.ToString());
                    }
                    break;
                case "National No":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    dgvPeople.DataSource = clsPerson.GetPeoleByNationalNo(txtFilter.Text.ToString());
                    break;
                case "First Name":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    dgvPeople.DataSource = clsPerson.GetPeoleByFirstName(txtFilter.Text.ToString());
                    break;
                case "Second Name":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    dgvPeople.DataSource = clsPerson.GetPeoleBySecondName(txtFilter.Text.ToString());
                    break;
                case "Third Name":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    dgvPeople.DataSource = clsPerson.GetPeoleByThirdName(txtFilter.Text.ToString());
                    break;
                case "Last Name":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    dgvPeople.DataSource = clsPerson.GetPeoleByLastName(txtFilter.Text.ToString());
                    break;
                case "Nationality":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    if (int.TryParse(txtFilter.Text, out int Countryid))
                        dgvPeople.DataSource = clsPerson.GetPeoleByNationaliaty(txtFilter.Text.ToString());
                    break;
                case "Gender":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    if (!string.IsNullOrEmpty(txtFilter.Text))
                    {
                        dgvPeople.DataSource = clsPerson.GetPeoleByGender(txtFilter.Text[0]);
                    }
                    break;
                case "Phone":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    if (int.TryParse(txtFilter.Text, out int Phone))
                        dgvPeople.DataSource = clsPerson.GetPeoleByPhone(txtFilter.Text.ToString());
                    break;
                case "Email":
                    _ReturnAllPeopleWhenFilterIsEmpty();
                    dgvPeople.DataSource = clsPerson.GetPeoleByEmail(txtFilter.Text.ToString());
                    break;

                default:
                    _HideTxtFilter();
                    dgvPeople.DataSource = clsPerson.GetAllPeople();
                    break;
            }
            
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            _HideTxtFilter();
            _refreshPeople();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPersonInfo frm = new frmAddEditPersonInfo(-1);
            frm.ShowDialog();
            _refreshPeople();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            _refreshPeople();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            
            frmAddEditPersonInfo frm = new frmAddEditPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _refreshPeople();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            _refreshPeople();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _refreshPeople();
        }

        private void cbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            _ShowTxtFilter();
        }

    }
}

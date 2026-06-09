using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUpdateTestType : Form
    {
        public frmUpdateTestType(int id)
        {
            InitializeComponent();
            _ID = id;
        }
        int _ID;
        clsTestType TestType;

        

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            TestType = clsTestType.Find(_ID);
            lblID.Text = TestType.Id.ToString();
            txtTitle.Text = TestType.Title.ToString();
            txtDescription.Text = TestType.Description.ToString();
            txtFees.Text = TestType.Fees.ToString();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isControl = char.IsControl(e.KeyChar);
            bool isDot = e.KeyChar == '.' && !txtFees.Text.Contains('.');

            if (!isDigit && !isControl && !isDot)
            {
                e.Handled = true; // block anything else
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (TestType == null) return;

            if (!double.TryParse(txtFees.Text, out double fees))
            {
                MessageBox.Show("Please enter a valid fee.");
                return;
            }

            TestType.Title = txtTitle.Text;
            TestType.Fees = fees;

            if (TestType.UpdateTestType())
                MessageBox.Show("Application Type updated successfully.");
            else
                MessageBox.Show("Update failed. Please try again.");
        }
    }
}

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
    public partial class frmUpdateApplicationType : Form
    {
        
        public frmUpdateApplicationType(int id)
        {
            InitializeComponent();
            _ID = id;
        }
        int _ID;
        clsApplicationTypes AppType;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
                AppType = clsApplicationTypes.GetAppTypeByID(_ID);
            lblID.Text = AppType.Id.ToString();
            txtTitle.Text = AppType.Title.ToString();
            txtFees.Text = AppType.Fees.ToString();

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AppType == null) return;

            if (!double.TryParse(txtFees.Text, out double fees))
            {
                MessageBox.Show("Please enter a valid fee.");
                return;
            }

            AppType.Title = txtTitle.Text;
            AppType.Fees = fees;

            if (AppType.UpdateAppType())
                MessageBox.Show("Application Type updated successfully.");
            else
                MessageBox.Show("Update failed. Please try again.");
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

        private void txtFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _RefreshData()
        {
            dgvUsers.DataSource = clsUser.GetAllUsers();
            lblRecords.Text = (dgvUsers.RowCount - 1).ToString();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddUpdateUser frm = new AddUpdateUser(-1);
            frm.ShowDialog();
            _RefreshData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

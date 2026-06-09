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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshData()
        {
            dgvApplicationTypes.DataSource = clsApplicationTypes.GetApplicationTypes();
            lblRecords.Text = dgvApplicationTypes.RowCount.ToString();
        }
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshData();
        }
    }
}

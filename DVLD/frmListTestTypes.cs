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
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void _RefreshData()
        {
            dgvTestTypes.DataSource = clsTestType.GetTestTypes();
            lblRecords.Text = dgvTestTypes.RowCount.ToString();
        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmUpdateTestType frm = new frmUpdateTestType((int) dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshData();
        }
    }
}

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
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void _RefreshData()
        {
            dgvUsers.DataSource = clsDriver.GetAllDrivers();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }
    }
}

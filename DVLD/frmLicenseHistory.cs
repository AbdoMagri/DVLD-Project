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
    public partial class frmLicenseHistory : Form
    {
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private int _PersonID = -1;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlFilterPerson1.FillTextBoxFromOutSide(_PersonID.ToString());
            ctrlFilterPerson1.btnSearchClickFromOutside(sender, e);
            _RefreshData();
        }

        private void _RefreshData()
        {
            dgvLocalDrivingLicenses.DataSource = clsLicense.GetSpecificLicenses(clsDriver.FindByPersonID(_PersonID).DriverID);
        }
    }
}

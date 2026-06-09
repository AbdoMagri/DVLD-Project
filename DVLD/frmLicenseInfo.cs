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
    public partial class frmLicenseInfo : Form
    {
        public frmLicenseInfo(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
        }
        private int _LDLAppID = -1;
        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo1.LoadData(_LDLAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

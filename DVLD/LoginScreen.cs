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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = clsUser.FindUserByUserNameAndPassword(txtUserName.Text.ToString(), txtPassword.Text.ToString());
            if (clsGlobal.CurrentUser != null) {
                if (!clsGlobal.CurrentUser.IsActive)
                {
                    MessageBox.Show("This account is not active , please contact your admin", "User Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Hide();
                Form1 frm = new Form1(clsGlobal.CurrentUser);
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid UserName/Password, try Agane","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
        }
    }
}

using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlFilterPerson : UserControl
    {
        private clsPerson person;
        public string id { get { return ctrlPersonInfo1.id; } }
        public ctrlFilterPerson()
        {
            InitializeComponent();
        }

        private void _FindAndFillInfo()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    person = clsPerson.FindByNationalNo(textBox1.Text.ToString());
                    break;
                case 1:
                    if (int.TryParse(textBox1.Text, out int id))
                        person = clsPerson.Find(id);
                    break;
                default:
                    break;
            }
            if (person == null)
            {
                MessageBox.Show("Person with " + comboBox1.SelectedItem.ToString() + " " + textBox1.Text.ToString() + " not found");
                return;
            }
            else
            {
                ctrlPersonInfo1.LoadInfo(person.Id);
            }
        }

        public void FillTextBoxFromOutSide(string st)
        {
            comboBox1.SelectedIndex = 1;
            textBox1.Text = st;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _FindAndFillInfo();
        }

        public void btnSearchClickFromOutside(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            gbFilter.Enabled = false;
        }

        private void ctrlFilterPerson_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }


    }
}

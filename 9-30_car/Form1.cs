using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_30_car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            String text = "You have selected: \n";
            CheckBox[] checkBoxes = { cb_audi, cb_BMW, cb_por, cb_audi };
            RadioButton[] radioButtons = { rdo_pour, rdo_pick, rdo_raw };
            foreach (CheckBox cb in checkBoxes)
            {
                if (cb.Checked)
                {
                    text += cb.Text + "\n";
                }
            }
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Checked)
                {
                    text += rb.Text + "\n";
                }
            }
            MessageBox.Show(text);
        }
    }
}

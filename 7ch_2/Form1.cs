using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7ch_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_string_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("문자열 입력");
            tb_string.Text = str;
        }

        private void btn_int_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("정수 입력");
            if (int.TryParse(input, out int number))
            {
                tb_int.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("올바른 정수를 입력하세요.");
            }
        }

        private void btn_float_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("실수 입력");
            if (float.TryParse(str, out float number))
            {
                tb_float.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("올바른 실수를 입력하세요.");
            }
        }
    }
}

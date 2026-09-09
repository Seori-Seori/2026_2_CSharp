using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "안녕하세요, 서리님!";
        }
    }
}
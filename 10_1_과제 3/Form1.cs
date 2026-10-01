using System;
using System.Windows.Forms;

namespace _10_1_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // TODO: 누른 화살표 키에 따라 이동 방향을 결정한다.
            // TODO: pb_image.Location을 해당 방향으로 10픽셀 옮긴다.
        }
    }
}

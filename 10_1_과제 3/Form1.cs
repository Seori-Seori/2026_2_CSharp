using System;
using System.Windows.Forms;
using System.Drawing; // Point를 사용해 PictureBox 위치를 변경하기 위해 사용
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
            if(e.KeyCode == Keys.Up)
            {
                pb_image.Location = new Point(pb_image.Location.X, pb_image.Location.Y - 10);
            }
            else if (e.KeyCode == Keys.Down)
            {
                pb_image.Location = new Point(pb_image.Location.X, pb_image.Location.Y + 10);
            }
            else if (e.KeyCode == Keys.Left)
            {
                pb_image.Location = new Point(pb_image.Location.X - 10, pb_image.Location.Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pb_image.Location = new Point(pb_image.Location.X + 10, pb_image.Location.Y);
            }
        }
    }
}

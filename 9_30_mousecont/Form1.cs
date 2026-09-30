using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_30_mousecont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_image_Click(object sender, EventArgs e)
        {

        }

        private void pb_image_DoubleClick(object sender, EventArgs e)
        {
            if(pb_image.SizeMode == PictureBoxSizeMode.Normal)
            {
                pb_image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if(pb_image.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                pb_image.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pb_image.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void pb_image_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                tb_type.Text = "Left Button";
            }else if (e.Button == MouseButtons.Right)
            {
                tb_type.Text = "오른쪽";
            }
            else
            {
                tb_type.Text = "가운데";
            }

            if()
        }
    }
}

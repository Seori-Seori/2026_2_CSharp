using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7ch_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pb_image.Image = Bitmap.FromFile("C:\\CookC#\\w05_img\\dog1.png");
        }

        private void 닫기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램을 종료합니다.");
            this.Close();
        }

        private void pb_image_Click(object sender, EventArgs e)
        {

        }

        private void 파일열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "이미지 파일 (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if((ofd.ShowDialog() == DialogResult.Cancel))
                    return;
            pb_image.Image = Bitmap.FromFile(ofd.FileName);
        }

        private void tbar_image_Scroll(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pb_image.Image);
            int R,G, B;
            Color c;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    c = bitmap.GetPixel(i, j);
                    R = c.R + tbar_image.Value;
                    G = c.G + tbar_image.Value;
                    B = c.B + tbar_image.Value;
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    bitmap.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
        }
    }
}
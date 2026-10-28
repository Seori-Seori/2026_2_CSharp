using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_28_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int XSize = 512;
        int YSize = 512;

        Bitmap bitmap;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(XSize, YSize);
            PictureBox.Location = new System.Drawing.Point(0, 0);
            PictureBox.Size = new System.Drawing.Size(XSize, YSize);
            bitmap = new Bitmap(XSize, YSize);

            Random rand = new Random();

            for(int i = 0; i < XSize; i++)
            {
                for(int k = 0; k <YSize; k++)
                {
                    byte data = (byte)rand.Next(0, 256);
                    Color color = Color.FromArgb(data, data, data);

                    bitmap.SetPixel(i, k, color);
                }
              
            }
            PictureBox.Image = bitmap;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

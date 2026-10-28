using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            bitmap = new Bitmap(XSize, YSize);
            byte[,] inImage;
            void LoadImage(string fname)
            {
                BinaryReader fp = new BinaryReader(File.Open(fname, FileMode.Open));
                inImage = new byte[YSize, XSize];

                for (int i = 0; i < XSize; i++)
                {
                    for (int k = 0; k < YSize; k++)
                    {
                        inImage[i, k] = fp.ReadByte();
                        fp.Close();
                    }
                }
                fp.Close();
            }

            void DisplayImage()
            {
                for (int i = 0; i < XSize; i++)
                {
                    for (int k = 0; k < YSize; k++)
                    {
                        byte data = inImage[k, i];
                        Color color = Color.FromArgb(data, data, data);
                        bitmap.SetPixel(i, k, color);
                    }
                    PictureBox.Image = bitmap;
                }
            }
        }
        int XSize = 512;
        int YSize = 512;

        Bitmap bitmap;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(XSize, YSize);
            PictureBox.Location = new System.Drawing.Point(0, 0);
            PictureBox.Size = new System.Drawing.Size(XSize, YSize);

            string fileName = "C:\\CookC#\\Images\\RAW\\LENNA512.raw";
            LoadImage(fileName);

            DisplayImagea();
              
            }
           
              
            

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

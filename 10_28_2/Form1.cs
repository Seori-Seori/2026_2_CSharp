using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _10_28_2
{
    public partial class Form1 : Form
    {
        int XSize = 512;
        int YSize = 512;
        byte[,] inImage;
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        void LoadImage(string fname)
        {
            inImage = new byte[YSize, XSize];

            using (BinaryReader fp = new BinaryReader(File.OpenRead(fname)))
            {
                for (int i = 0; i < YSize; i++)
                {
                    for (int k = 0; k < XSize; k++)
                    {
                        inImage[i, k] = fp.ReadByte();
                    }
                }
            }
        }

        void DisplayImage()
        {
            for (int i = 0; i < YSize; i++)
            {
                for (int k = 0; k < XSize; k++)
                {
                    byte data = inImage[i, k];
                    Color color = Color.FromArgb(data, data, data);
                    bitmap.SetPixel(k, i, color);
                }
            }

            PictureBox.Image = bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(XSize, YSize);
            PictureBox.Location = new Point(0, 0);
            PictureBox.Size = new Size(XSize, YSize);

            // 실행 파일은 프로젝트의 bin\Debug에 있으므로 저장소의 RAW 폴더로 이동
            string fileName = Path.GetFullPath(
                Path.Combine(Application.StartupPath, @"..\..\..\RAW\LENNA512.raw"));

            if (!File.Exists(fileName))
            {
                MessageBox.Show("RAW 파일을 찾을 수 없습니다.\n" + fileName);
                return;
            }

            try
            {
                if (new FileInfo(fileName).Length != XSize * YSize)
                {
                    MessageBox.Show("512 x 512 크기의 RAW 파일이 아닙니다.");
                    return;
                }

                LoadImage(fileName);
                bitmap = new Bitmap(XSize, YSize);
                DisplayImage();
            }
            catch (IOException ex)
            {
                MessageBox.Show("RAW 파일을 읽는 중 오류가 발생했습니다.\n" + ex.Message);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

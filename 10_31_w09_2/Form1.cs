using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _10_31_w09_2
{
    public partial class Form1 : Form
    {
        int XSize = 512;
        int YSize = 512;
        byte[,] inImage1;
        byte[,] inImage2;
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        void LoadImage(string fname1, string fname2)
        {
            inImage1 = new byte[YSize, XSize];
            inImage2 = new byte[YSize, XSize];

            using (BinaryReader fp1 = new BinaryReader(File.OpenRead(fname1)))
            using (BinaryReader fp2 = new BinaryReader(File.OpenRead(fname2)))
            {
                for (int i = 0; i < YSize; i++)
                {
                    for (int k = 0; k < XSize; k++)
                    {
                        inImage1[i, k] = fp1.ReadByte();
                        inImage2[i, k] = fp2.ReadByte();
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
                    int data = (inImage1[i, k] + inImage2[i, k]) / 2;
                    Color color = Color.FromArgb(data, data, data);
                    bitmap.SetPixel(k, i, color);
                }
            }

            PictureBox.Image = bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "w09 과제 2 - RAW 사진 평균 합성";
            this.ClientSize = new Size(XSize, YSize);
            PictureBox.Location = new Point(0, 0);
            PictureBox.Size = new Size(XSize, YSize);

            // 솔루션과 같은 위치에 RAW 폴더를 두면 됩니다.
            string rawFolder = Path.GetFullPath(
                Path.Combine(Application.StartupPath, @"..\..\..\RAW"));
            string fileName1 = Path.Combine(rawFolder, "Flower512.raw");
            string fileName2 = Path.Combine(rawFolder, "Night512.raw");

            if (!File.Exists(fileName1) || !File.Exists(fileName2))
            {
                MessageBox.Show("RAW 파일 두 개를 확인해주세요.\n" +
                    fileName1 + "\n" + fileName2);
                return;
            }

            try
            {
                if (new FileInfo(fileName1).Length != XSize * YSize ||
                    new FileInfo(fileName2).Length != XSize * YSize)
                {
                    MessageBox.Show("두 RAW 파일 모두 512 x 512 크기여야 합니다.");
                    return;
                }

                LoadImage(fileName1, fileName2);
                bitmap = new Bitmap(XSize, YSize);
                DisplayImage();
            }
            catch (IOException ex)
            {
                MessageBox.Show("RAW 파일을 읽는 중 오류가 발생했습니다.\n" + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("RAW 파일 접근 권한 오류\n" + ex.Message);
            }
        }
    }
}

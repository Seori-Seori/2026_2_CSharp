using System;
using System.Windows.Forms;
using System.Drawing; // Image.FromFile()로 이미지 파일을 불러오기 위해 사용
namespace _10_1_과제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pb_image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string[] images =
            {
                @"C:\CookC#\w05_img\dog1.png",
                @"C:\CookC#\w05_img\cat1.png",
                @"C:\CookC#\w05_img\bird1.png"
            };

            string selectedImage = images[random.Next(images.Length)];

            pb_image.Image = Image.FromFile(selectedImage);

        }

        private void pb_image_Click(object sender, EventArgs e)
        {
            
        }
    }
}

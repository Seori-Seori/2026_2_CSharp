using System;
using System.Windows.Forms;

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
            // TODO: w05_img의 동물 사진 중 하나를 무작위로 고른다.
            // TODO: 선택한 이미지를 pb_image.Image에 표시한다.
            // 예: 저장소 루트의 w05_img/dog1.png, cat1.png, bird1.png
        }
    }
}

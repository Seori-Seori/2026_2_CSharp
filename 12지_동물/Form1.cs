using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12지_동물
{
    public partial class ｒｕｎ : Form
    {
        public ｒｕｎ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         this.Text = "12지 동물 띠 알아보기";

        int yesr = int.Parse(textBox1.Text);
            string imageFile = "C:\\CookC#\\images\\";

            switch (yesr % 12)
            {
                case 0:
                    imageFile += "원숭이.png";
                    break;
                case 1:
                    imageFile += "닭.png";
                    break;
                case 2:
                    imageFile += "개.png";
                    break;
                case 3:
                    imageFile += "돼지.png";
                    break;
                case 4:
                    imageFile += "쥐.png";
                    break;
                case 5:
                    imageFile += "소.png";
                    break;
                case 6:
                    imageFile += "호랑이.png";
                    break;
                case 7:
                    imageFile += "토끼.png";
                    break;
                case 8:
                    imageFile += "용.png";
                    break;
                case 9:
                    imageFile += "뱀.png";
                    break;
                case 10:
                    imageFile += "말.png";
                    break;
                case 11:
                    imageFile += "양.png";
                    break;
            }

            pictureBox1.Image = Image.FromFile(imageFile);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(imageFile);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}

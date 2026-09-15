using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace All_InOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int ghp;
        int gattack;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }



        private void label1_Click(object sender, EventArgs e)
        {
           Text = "이름을 입력하세요";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        int finalHp ;
        int finalAttack ;
        private void button1_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("이름을 입력하세요");
                return;
            }
            if (직업.SelectedItem == null)
            {
                MessageBox.Show("직업을 선택하세요");
                return;
            }
            if(radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("난이도를 선택하세요");
                return;
            }


            if (직업.SelectedItem.ToString() == "전사")
            {
                
                ghp = 1400;
                gattack = 70;
            }
            else if (직업.SelectedItem.ToString() == "법사")
            {
               
                ghp = 600;
                gattack = 160;
            }
            else if (직업.SelectedItem.ToString() == "궁수")
            {
                ghp = 900;
                gattack = 105;
            }

            else if (직업.SelectedItem.ToString() == "용사")
            {
                ghp = 1100;
                gattack = 95;
            }
            else if (직업.SelectedItem.ToString() == "백수")
            {
                ghp = 750;
                gattack = 80;
            }


            if (radioButton1.Checked)
            {
                finalHp = ghp + 300;
                finalAttack = gattack + 20;
                label4.Text = "hp: " + finalHp;
                label6.Text = "공격력: " + finalAttack;
            }
            else if (radioButton2.Checked)
            {
                finalHp = ghp ;
                finalAttack = gattack;
                label4.Text = "hp: " + finalHp;
                label6.Text = "공격력: " + finalAttack;
            }


            else if (radioButton3.Checked)
            {
                finalHp = ghp - 200;
                finalAttack = gattack - 10;
                label4.Text = "hp: " + finalHp;
                label6.Text = "공격력: " + finalAttack;
            }

            string name = textBox1.Text;
            string job = 직업.SelectedItem.ToString();

            string dyp = "";
            if(radioButton1.Checked)
            {
                dyp = "쉬움";
            }
            else if (radioButton2.Checked)
            {
                dyp = "중간";
            }
            else if (radioButton3.Checked)
            {
                dyp = "어려움";
            }
            MessageBox.Show("이름: " + name + "\n직업: " + job + "\n난이도: " + dyp + "\n최종 HP: " + finalHp + "\n최종 공격력: " + finalAttack, "캐릭터 생성 완료!");


        } 

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int monsterHp;
        int monsterAttack;
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            game = true;
            Random rand = new Random();
            monsterHp = rand.Next(500, 1201);//랜덤 함수 마지막에 +1을 해줘야 1200까지 나옴
            monsterAttack = rand.Next(50, 151);
            MessageBox.Show("몬스터 체력: " + monsterHp);
            label7.Text = "몬스터 체력: " + monsterHp;
            Console.WriteLine("몬스터 체력: " + monsterHp);
            label8.Text = "공격력: " + finalAttack;
            Console.WriteLine("공격력: " + finalAttack);
            label9.Text = "몬스터  공격력: " + monsterAttack;
            Console.WriteLine("몬스터  공격력: " + monsterAttack);
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label8.Text = "공격력: " + finalAttack;
            Console.WriteLine("공격력: " + finalAttack);
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }
        bool game = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (game == false)
            {
             MessageBox.Show("전투를 시작하세요.");
                return;// 게임 로직
            }
            monsterHp -= finalAttack;
            listBox1.Items.Add($"{textBox1.Text}이(가) 몬스터에게 {finalAttack}의 데미지를 입혔습니다.");
            if (monsterHp < 0)
            {
                monsterHp = 0;
            }
            if(monsterHp > 0)
            {
                finalHp -= monsterAttack;
                listBox1.Items.Add($"{textBox1.Text}이(가) 몬스터에게 {monsterAttack}의 데미지를 입었습니다.");
                if (finalHp < 0)
                {
                    finalHp = 0;
                }
                label4.Text = "hp: " + finalHp;
                if (finalHp == 0)
                {
                    game = false;
                    MessageBox.Show("패배했습니다.");
                }
            }
            if (monsterHp == 0)
            {
                pictureBox1.Visible = false;
                game = false;
                MessageBox.Show("몬스터를 처치했습니다!");
            }
            label7.Text = "몬스터 체력: " + monsterHp;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= 10; // Move the picture box to the left
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 10; // Move the picture box to the right        
            }
            else if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top -= 10; // Move the picture box up
            }
            else if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top += 10; // Move the picture box down
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            int hp;
            int attack;
            if (직업.SelectedItem.ToString() == "전사")
            {
                hp = 1000;
                attack = 20;
                ghp = hp;
                gattack = attack;
            }
            else if (직업.SelectedItem.ToString() == "법사")
            {
                hp = 100;
                attack = 525;
                ghp = hp;
                gattack = attack;
            }
            else if (직업.SelectedItem.ToString() == "궁수")
            {
                hp = 400;
                attack = 15;
                ghp = hp;
                gattack = attack;
            }

            else if (직업.SelectedItem.ToString() == "용사")
            {
                hp = 2000;
                attack = 34440;
                ghp = hp;
                gattack = attack;
            }
            else if (직업.SelectedItem.ToString() == "백수")
            {
                hp = 50;
                attack = 5;
                ghp = hp;
                gattack = attack;
            }
            int finalHp = ghp;
            int finalAttack = gattack;

            if (radioButton1.Checked)
            {
                finalHp = ghp + 2999;
                finalAttack = gattack + 20;
                label4.Text = "hp: " + finalHp;
                label6.Text = "공격력: " + finalAttack;
            }
            else if (radioButton2.Checked)
            {
                finalHp = ghp + 100;
                finalAttack = gattack + 25;
                label4.Text = "hp: " + finalHp;
                label6.Text = "공격력: " + finalAttack;
            }


            else if (radioButton3.Checked)
            {
                finalHp = ghp - 600;
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
    }
}

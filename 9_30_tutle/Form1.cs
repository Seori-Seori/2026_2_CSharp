using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace _9_30_tutle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }

        static bool IsNumberInArry(int[] ar, int num)
        {
            bool dupYN = false;
            for(int i = 0; i< ar.Length; i++)
            {
                if (ar[i] == num)
                
                    dupYN = true;
                    break;
                
            }
            return dupYN;
        }
        static Random rnd = new Random();
        static void GetLotto(int[] ary)
        {
            int idx = 0;
            int pickNum;

            while (true)
            {
                pickNum = rnd.Next(1, 45);
                if (IsNumberInArry(ary, pickNum))
                    continue;
                ary[idx] = pickNum;
                if(idx >= 5)
                    break;
                idx++;
            }
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            int swidth = 600, sheight = 600;
            this.Text = "거북이 로또";
            this.ClientSize = new Size(swidth, sheight);
            Turtle.Delay = 50;

            int[] lottoAry = new int[6];

            GetLotto(lottoAry);

            Array.Sort(lottoAry,0,6);

            string lottoText = "";
            foreach (int num in lottoAry)
            {
                lottoText += num.ToString() + " ";
            }
            tb_lotto.Text = lottoText;

           
        }
    }
}

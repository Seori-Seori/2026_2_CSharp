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
namespace pj3_turtle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int swidth = 400, sheight = 400, exitcode = 0;
            int r, g, b, angle, dist;
            float curX, curY;

            this.Text = "거북이 마음대로 다님";
            this.ClientSize = new Size(swidth, sheight);

            Random rand = new Random();
            Turtle.Delay = 50;
            while(true)
            {
                r = rand.Next(0, 256);
                g = rand.Next(0, 256);
                b = rand.Next(0, 256);
                Turtle.PenColor = Color.FromArgb(r, g, b);
                angle = rand.Next(0, 360);
                dist = rand.Next(1, 100);
                Turtle.Rotate(angle);
                Turtle.Forward(dist);
                curX = Turtle.X;
                curY = Turtle.Y;
                if ((-swidth/2 <= curX && curX <= swidth/2) && (-sheight/2 <= curY && curY <= sheight/2))
                {

                }
                else
                {
                    Turtle.PenUp();
                    Turtle.MoveTo(0, 0);
                    Turtle.PenDown();

                    exitcode++;
                    if(exitcode == 5)
                    {
                        break;
                    }
                }
            }
            


            /*원을 그리는 거북이
            Turtle.PenColor = Color.MediumPurple;
            Turtle.PenUp();
            Turtle.MoveTo(-150, 0);
            for(int i = 0; i < 9; i++)
            {
                Turtle.PenDown();   
                Turtle.Rotate(20);
                Turtle.Forward(50);

                Turtle.PenUp();
                Turtle.Rotate(20);
                Turtle.Forward(50);
            }*/
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }
    }
}

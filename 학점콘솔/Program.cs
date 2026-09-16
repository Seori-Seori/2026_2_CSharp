using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 학점콘솔
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;

            Random rnd = new Random();

            for( int i =0; i < 5; i++)
            {
                score = rnd.Next(0, 101);
                Console.WriteLine("취득 점수" + score+ "==>");
                if (score >= 90)
                {
                    Console.WriteLine("학점: A");
                }
                else if (score >= 80)
                {
                    Console.WriteLine("학점: B");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("학점: C");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("학점: D");
                }
                else
                {
                    Console.WriteLine("학점: F");
                }
            }
        }
    }
}

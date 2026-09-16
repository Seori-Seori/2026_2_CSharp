using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 2, b = 3, c = 4;
            int result1, mok, namugi;
            float result2;

            result1 = a + b - c;
            Console.WriteLine("{0:D} + {1:D} - {2:D} = {3:D}", a, b, c, result1);

            result1 = a + b * c;
            Console.WriteLine("{0:D} + {1:D} * {2:D} = {3:D}", a, b, c, result1);

            result2 = a * b /(float)c;
            Console.WriteLine("{0:D} * {1:D} / {2:D} = {3:F2}", a, b, c, result2);

            mok = c / b;
            Console.WriteLine("{0:D} / {1:D}의 몫은 {2:D}", c, b, mok);

            namugi = c % b;
            Console.WriteLine("{0:D} / {1:D}의 나머지는 {2:D}", c, b, namugi); */


            //두번 째 실습
            string s1 = "100", s2 = "100.123";

            Console.WriteLine(int.Parse(s1) + (float.Parse(s2)));

            int n1 = 100;
            float n2 = 100.123f;
            Console.WriteLine(n1.ToString() + n2.ToString());



        }
    }
}

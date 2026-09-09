using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int result;

            string str;

            Console.Write("첫번쨰 계산할 값을 입력하세요 =>");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("두번째 계산할 값을 입력하세요 =>");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);


            result = a + b;
            Console.WriteLine(a + "+" + b + "=" + result);

            result = a - b;
            Console.WriteLine(a + "-" + b + "=" + result);

            result = a * b;
            Console.WriteLine(a + "*" + b + "=" + result);

            result = a / b;
            Console.WriteLine(a + "/" + b + "=" + result);


        }
    }
}

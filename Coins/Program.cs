using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int c500, c100, c50, c10;

            Console.Write("교환할 돈은 얼마인가요? : ");
            money = int.Parse(Console.ReadLine());

            c500 = money / 500;
            money %= 500;

            c100 = money / 100;
            money %= 100;

            c50 = money / 50;
            money %= 50;

            c10 = money / 10;
            money %= 10;

            Console.WriteLine("오백원=> {0}개", c500);
            Console.WriteLine("백원=> {0}개", c100);
            Console.WriteLine("오십원=> {0}개", c50);
            Console.WriteLine("십원=> {0}개", c10);
            Console.WriteLine("바꾸지 못한 돈=> {0}원", money);
        }
    }
}

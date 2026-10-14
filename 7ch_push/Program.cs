using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _7ch_push
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter outFp;
            string outStr;
            string fName;

            outFp = new StreamWriter("C:\\Temp\\data2.txt");

            while (true)
            {
                Console.Write("내용입력:");

                outStr = Console.ReadLine();

                if (outStr != "")
                {
                    outFp.WriteLine(outStr);

                }
                else
                {
                    outFp.Close();
                    Console.WriteLine("정상처리됨.");
                    break;
                }
            }
        }
    }
}

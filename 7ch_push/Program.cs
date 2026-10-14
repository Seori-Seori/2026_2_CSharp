using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management.Instrumentation;
namespace _7ch_push
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader inFp;
            StreamWriter outFp;
            string outStr;
            string fName;
            string inStr;
            /*outFp = new StreamWriter("C:\\Temp\\data2.txt");

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
                }*/

            inFp = new StreamReader("C:\\windows\\win.ini");
            outFp = new StreamWriter("C:\\Temp\\data3.txt");

            while (true)
            {
                inStr  = inFp.ReadLine();
                if (inStr == null) break;
                outFp.WriteLine(inStr);
            }
            inFp.Close();
            outFp.Close();
            Console.WriteLine("정상처리됨.");
        }
    }
}

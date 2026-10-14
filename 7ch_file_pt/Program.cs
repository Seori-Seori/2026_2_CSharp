using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _7ch_file_pt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader inFp;
            string inStr;

            inFp = new StreamReader("C:\\Temp\\data1.txt");
            /*
            inStr = inFp.ReadLine();
            Console.WriteLine(inStr);

            inStr = inFp.ReadLine();
            Console.WriteLine(inStr);

            inStr = inFp.ReadLine();
            Console.WriteLine(inStr);
            */
            string[] inStrAry;
            inStrAry = File.ReadAllLines("C:\\Temp\\data1.txt");
            foreach (string str in inStrAry)
            {
                Console.WriteLine(str);
            }
            //inFp.Close();
        }
    }
}

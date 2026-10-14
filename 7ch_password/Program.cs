using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _7ch_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader inFp;
            StreamWriter outFp;
            string inFname, outFname;
            string inStr, outStr;
            string secuYN;
            int secu = 0;

            Console.WriteLine("1.암호화 2.해독중 선택:");
            secuYN = Console.ReadLine();

            Console.WriteLine("입력 파일명:");
            inFname = Console.ReadLine();
            Console.WriteLine("출력 파일명:");
            outFname = Console.ReadLine();

            if(secuYN == "1")
            {
                secu = 100;
            } else if(secuYN == "2")
            {
                secu = -100;
            }
            inFp = new StreamReader(inFname);
            outFp = new StreamWriter(outFname);

            while(true){
                inStr = inFp.ReadLine();
                if (inStr == null)
                {
                    break;
                }
                outStr = "";

                foreach(char ch in inStr)
                {
                    int chNum = (int)ch;
                    chNum += secu;
                    outStr += (char)chNum;
                }
                outFp.WriteLine(outStr);
            }

            inFp.Close();
            outFp.Close();
            Console.WriteLine("작업 완료");

        }
    }
}

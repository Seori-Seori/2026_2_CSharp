using System;

namespace _10_31_w09_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("암호화할 문자열 => ");
            string inStr = Console.ReadLine() ?? "";

            Console.Write("암호화에 사용할 숫자 => ");
            int secu;
            if (!int.TryParse(Console.ReadLine(), out secu))
            {
                Console.WriteLine("숫자를 올바르게 입력해주세요.");
                return;
            }

            string outStr = "";
            foreach (char ch in inStr)
            {
                outStr += unchecked((char)(ch + secu));
            }

            string deStr = "";
            foreach (char ch in outStr)
            {
                deStr += unchecked((char)(ch - secu));
            }

            Console.WriteLine("*** 처리 결과 ***");
            Console.WriteLine("암호화된 문자열 => {0}", outStr);
            Console.WriteLine("암호 해석된 문자열 => {0}", deStr);
        }
    }
}

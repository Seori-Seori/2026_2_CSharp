using System;
using System.IO;

namespace _01_28_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numAry = new int[2];

            Console.Write("숫자1 -->");
            numAry[0] = int.Parse(Console.ReadLine());
            Console.Write("숫자2 -->");
            numAry[1] = int.Parse(Console.ReadLine());

            try
            {
                int res = numAry[0] / numAry[1];                 // DivideByZeroException
                numAry[0] = int.Parse("백");                    // FormatException
                numAry[2] = numAry[0];                         // IndexOutOfRangeException
                Directory.Delete(@"C:\없는디렉터리\", true);  // DriveNotFoundException (PPT 표기)
                File.Move(@"C:\없는파일1.exe", @"C:\없는파일2.exe"); // FileNotFoundException
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DriveNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) // 위에서 처리하지 못한 예외
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

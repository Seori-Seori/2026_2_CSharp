using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _10_28_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1, file2, folder1, folder2;

            folder1 = "C:\\Temp\\";
            if (!Directory.Exists(folder1))
            {
                Directory.CreateDirectory(folder1);
                Console.WriteLine("0.{0} created.", folder1);
            }

            file1 = "C:\\Windoes\\Write.exe";
            file2 = "C:\\Temp\\Write.exe";
            if (!File.Exists(file1))
            {
                Console.WriteLine("1.{0} not found.", file1);
            }
            else
            {
                File.Copy(file1, file2, true);
                Console.WriteLine("2.{0} copied to {1}.", file1, file2);
            }
            file1 = "C:\\Windows\\notepad.exe";
            file2 = "C:\\Temp\\notepad.exe";
            if (!File.Exists(file1))
            {
                Console.WriteLine("3.{0} not found.", file1);
            }
            else
            {
                File.Copy(file1, file2, true);
                Console.WriteLine("4.{0} copied to {1}.", file1, file2);
            }

            folder1 = "C:\\Temp\\TestDir\\";
            if (!Directory.Exists(folder1))
            {
                Directory.CreateDirectory(folder1);
                Console.WriteLine("5.{0} created.", folder1);
            }
            file1 = "C:\\Temp\\Write.exe";
            file2 = "C:\\Temp\\TestDir\\Write.exe";

            if (File.Exists(file1) && !File.Exists(file2))
            {
                File.Move(file1, file2);
                Console.WriteLine("6.{0} moved to {1}.", file1, file2);

            }
            else
            {
                Console.WriteLine("7.{0} not found or {1} already exists.", file1, file2);
            }
            Console.WriteLine("지금 탐색기로 확인 후 엔터키를 누르세요.");
            Console.ReadLine();
            file1 = "C:\\Temp\\write_new.exe";

            if (File.Exists(file1))
            {
                File.Delete(file1);
                Console.WriteLine("8.{0} deleted.", file1);

            }
            else
            {
                Console.WriteLine("9.{0} not found.", file1);
            }
            folder1 = "C:\\Temp\\TestDir_new\\";
            if (Directory.Exists(folder1))
            {
                Directory.Delete(folder1, true);
                Console.WriteLine("10.{0} deleted.", folder1);
            }
            else
            {
                Console.WriteLine("11.{0} not found.", folder1);
            }
        }
    }
}
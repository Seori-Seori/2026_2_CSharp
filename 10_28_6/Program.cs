using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace _10_28_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder1, folder2;

            folder1 = @"C:\Windows\Help";
            folder2 = @"C:\Temp\CHelp";

            if (Directory.Exists(folder1))
            {
                FileSystem.CopyDirectory(folder1, folder2, UIOption.AllDialogs);
                Console.WriteLine("{0} 폴더가 {1} 폴더로 복사됨", folder1, folder2);
            }
            else
            {
                Console.WriteLine("{0} 폴더를 찾을 수 없습니다.", folder1);
            }
        }
    }
}

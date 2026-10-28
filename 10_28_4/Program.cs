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

            folder1 = @"C:\Temp";
            if (!Directory.Exists(folder1))
            {
                Directory.CreateDirectory(folder1);
                Console.WriteLine("0.{0} created.", folder1);
            }

            // 1. 원본 파일 복사
            file1 = @"C:\Windows\notepad.exe";
            file2 = @"C:\Temp\notepad.exe";
            if (File.Exists(file1) && !File.Exists(file2))
            {
                File.Copy(file1, file2);
                Console.WriteLine("1.{0} copied to {1}.", file1, file2);
            }

            // 2. 같은 파일을 이름을 바꾸어 한 번 더 복사
            file1 = @"C:\Temp\notepad.exe";
            file2 = @"C:\Temp\notepad_new.exe";
            if (File.Exists(file1) && !File.Exists(file2))
            {
                File.Copy(file1, file2);
                Console.WriteLine("2.{0} copied to {1}.", file1, file2);
            }

            // 3. 파일을 옮길 폴더 생성
            folder1 = @"C:\Temp\TestDir";
            if (!Directory.Exists(folder1))
            {
                Directory.CreateDirectory(folder1);
                Console.WriteLine("3.{0} created.", folder1);
            }

            // 4. 파일 이동
            file1 = @"C:\Temp\notepad.exe";
            file2 = @"C:\Temp\TestDir\notepad.exe";
            if (File.Exists(file1) && !File.Exists(file2))
            {
                File.Move(file1, file2);
                Console.WriteLine("4.{0} moved to {1}.", file1, file2);
            }

            // 5. 폴더 이동(이름 변경)
            folder1 = @"C:\Temp\TestDir";
            folder2 = @"C:\Temp\TestDir_new";
            bool folderMoved = false;
            if (Directory.Exists(folder1) && !Directory.Exists(folder2))
            {
                Directory.Move(folder1, folder2);
                folderMoved = true;
                Console.WriteLine("5.{0} moved to {1}.", folder1, folder2);
            }

            Console.WriteLine("지금 탐색기로 C:\\Temp 폴더를 확인 후 Enter키를 누르세요.");
            Console.ReadLine();

            // 6. 이름을 바꿔 복사했던 파일 삭제
            file1 = @"C:\Temp\notepad_new.exe";
            if (File.Exists(file1))
            {
                File.Delete(file1);
                Console.WriteLine("6.{0} deleted.", file1);
            }

            // 7. 이번 실행에서 이동한 폴더 삭제
            folder1 = @"C:\Temp\TestDir_new";
            if (folderMoved && Directory.Exists(folder1))
            {
                Directory.Delete(folder1, true);
                Console.WriteLine("7.{0} deleted.", folder1);
            }
        }
    }
}

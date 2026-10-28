using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_28_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\Windows\Help";
            string[] fileAry = new string[] { };
            string[] dirAry = new string[] { };

            if (!Directory.Exists(folder))
            {
                Console.WriteLine("{0} 폴더가 없습니다.", folder);
                return;
            }

            // 접근할 수 없는 하위 폴더가 있어도 나머지 폴더는 계속 검색
            Stack<DirectoryInfo> folders = new Stack<DirectoryInfo>();
            folders.Push(new DirectoryInfo(folder));

            while (folders.Count > 0)
            {
                DirectoryInfo dinfo = folders.Pop();

                try
                {
                    foreach (DirectoryInfo dir in dinfo.GetDirectories())
                    {
                        Array.Resize(ref dirAry, dirAry.Length + 1);
                        dirAry[dirAry.Length - 1] = dir.FullName;

                        // 바로가기(연결 지점)는 재귀 검색에서 제외
                        if ((dir.Attributes & FileAttributes.ReparsePoint) == 0)
                            folders.Push(dir);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("폴더 접근 권한 없음: {0}", dinfo.FullName);
                }
                catch (IOException)
                {
                    Console.WriteLine("폴더 목록을 읽을 수 없음: {0}", dinfo.FullName);
                }

                try
                {
                    // 시작 폴더의 파일도 포함
                    foreach (FileInfo file in dinfo.GetFiles())
                    {
                        Array.Resize(ref fileAry, fileAry.Length + 1);
                        fileAry[fileAry.Length - 1] = file.FullName;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("파일 접근 권한 없음: {0}", dinfo.FullName);
                }
                catch (IOException)
                {
                    Console.WriteLine("파일 목록을 읽을 수 없음: {0}", dinfo.FullName);
                }
            }

            Console.WriteLine("Directories:{0}", dirAry.Length);
            foreach (string dir in dirAry)
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("Files:{0}", fileAry.Length);
            foreach (string file in fileAry)
            {
                Console.WriteLine(file);
            }
        }
    }
}

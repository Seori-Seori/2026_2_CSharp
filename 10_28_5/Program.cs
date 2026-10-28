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
            string folder = "C:\\Windoes\\Help\\";
            string[] fileAry = new string[] { };
            string[] dirAry = new string[] { };

            DirectoryInfo dinfo = new DirectoryInfo(folder);
            DirectoryInfo[] dirs = dinfo.GetDirectories("*", SearchOption.AllDirectories);

            foreach (DirectoryInfo dir in dirs)
            {
                Array.Resize(ref dirAry, dirAry.Length + 1);
                dirAry[dirAry.Length - 1] = dir.FullName;
                foreach(FileInfo file in dir.GetFiles())
                {
                    Array.Resize(ref fileAry, fileAry.Length + 1);
                    fileAry[fileAry.Length - 1] = file.FullName;
                }
            }
            Console.WriteLine("Directories:{0}", dirAry.Length);
            foreach (string dir in dirAry)
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine("Files:{0}", fileAry.Length );
            foreach (string file in fileAry)
            {
                Console.WriteLine(file);
            }
        }
    }
}

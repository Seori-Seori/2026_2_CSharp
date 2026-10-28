using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _10_28_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryReader inFp;
            BinaryWriter outFp;

            string inFile = "C:\\Temp\\Write.exe";
            string outFile = "C:\\Temp\\Copy.exe";

            inFp  = new BinaryReader(File.Open(inFile, FileMode.Open));
            outFp = new BinaryWriter(File.Open(outFile, FileMode.Create));

            long len = new FileInfo(inFile).Length;

            for(long i = 0; i < len; i++)
            {
                byte b = inFp.ReadByte();
                outFp.Write(b);
            }
            inFp.Close();
            outFp.Close();
            Console.WriteLine("File copy completed.");

        }
    }
}

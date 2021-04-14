using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIo
{
    class FileStreamDemo
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("c:\\demo\\abc.txt",FileMode.OpenOrCreate);
            Console.WriteLine("File Opend");
            f.WriteByte(70);
            Console.WriteLine("Data Written into File");
            f.Close();
            FileStream f1 = new FileStream("c:\\demo\\abc.txt", FileMode.OpenOrCreate);
            char a = (char)f1.ReadByte();
            Console.WriteLine("Data read from file : "+a);
            
            
            Console.ReadKey();
        }
    }
}

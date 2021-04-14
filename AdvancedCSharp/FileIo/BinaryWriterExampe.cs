using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIo
{
    class BinaryWriterExampe
    {
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("c:\\demo\\binaryfile.dat", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
                Console.WriteLine("Integer Value : " + reader.ReadInt32());
            }
        }
        static void Main()
        {
            string fileName = "c:\\demo\\binaryfile.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
                writer.Write(10);
            }
            Console.WriteLine("Data written successfully...");
            Console.WriteLine("----------Read Binary Data From File--------------");
            ReadBinaryFile();
            Console.ReadKey();
        }
    }
}

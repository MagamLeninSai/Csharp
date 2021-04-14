using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIo
{
    class StreamReaderExample
    {
        static void Main(string[] args)
        {

            FileStream f = new FileStream("c:\\demo\\b1.txt", FileMode.OpenOrCreate);

            Console.WriteLine("File opened");

            //declared stream reader
            StreamReader sr = new StreamReader(f);
            Console.WriteLine("Reading data from the file");

            string line = sr.ReadLine();

            Console.WriteLine("The data from the file is : " + line);

            //closing stream writer
            sr.Close();
            f.Close();

            Console.WriteLine("File Stream closed");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIo
{
    class DeSerializationDemo
    {
        static void Main()
        {
            String f = "c:\\demo\\serial.txt";

            //Open the file Serial.txt
            Stream s = File.Open(f,FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            //deserialize Object
            UserDetails ud = (UserDetails)bf.Deserialize(s);
            s.Close();
            Console.WriteLine();
            Console.WriteLine("After Deserialization Object Contents :");
            ud.GetDetails();
            Console.ReadKey();
        }
    }
}

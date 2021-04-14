using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIo
{
    class SeralizationDemo
    {
        static void Main()
        {
            UserDetails u1 = new UserDetails(101,"Lenin","Hyd");
            Console.WriteLine("Before Serialization object Contains :");
            u1.GetDetails();
           String  f = "c:\\demo\\serial.txt";
            if (File.Exists(f)) {
                File.Delete(f);
            }
            //Open File
            Stream s = File.Open(f,FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            //Serialize the object into its Binary Format
            bf.Serialize(s, u1);

            s.Close();
            Console.WriteLine("Serialization Successful");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPSDemo2
{
    class StringBuilderDemo
    {
        //Creating Mutable String
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Mike");
            sb.Append(", John");
            sb.Append(", Mary");
            sb.AppendLine();
            sb.Append("Welcome to C#");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder("Welcome World");
            sb1.Insert(8, "to Tutlane ");
            Console.WriteLine("Insert String: " + sb1);

            StringBuilder sb2 = new StringBuilder("Welcome to C#");
            sb2.Remove(8, 3);
            Console.WriteLine(sb2);

            StringBuilder sb3 = new StringBuilder("Welcome to C# World");
            sb3.Replace("C#", "Dot Net");
            Console.WriteLine(sb3);
            Console.WriteLine(sb3.Capacity);
            Console.ReadLine();

        }
    }
}

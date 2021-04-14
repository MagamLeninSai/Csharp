using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class ReadDemo
    {
        static void Main(String[] args) {
            int userInput;

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Input using Read() - ");
            userInput = Console.Read();  // Read() method will read ascii value of char
            Console.WriteLine("Ascii Value = {0}", userInput);
            Console.ReadKey();
        }
    }
}

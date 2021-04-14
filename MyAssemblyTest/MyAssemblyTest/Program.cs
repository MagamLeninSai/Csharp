using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace MyAssemblyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello For Testing My Assembly - Change Charactor");
            ChangeCharacter c = new ChangeCharacter();
            string u = c.UpperCase("m");
            string l = c.LowerCase("LENIN SAI");
            Console.WriteLine(u + "." + l);
            Console.ReadKey();
        }
    }
}

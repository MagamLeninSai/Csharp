using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssemblyTest
{
    class GcExample1
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("GC Max Generation :"+ GC.MaxGeneration);
            Console.ReadKey();
        }
    }
}

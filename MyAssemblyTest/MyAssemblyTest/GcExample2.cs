using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssemblyTest
{
    class GCBase
    {
        void display()
        {
            Console.WriteLine("Test Method");
        }
    }
    class GcExample2
    {
        static void Main()
        {
            // if we give true then it will calculate total-memory after tha program 
            //false means at that time what is total-memory
            Console.WriteLine("Total memory :" + GC.GetTotalMemory(false));

            GCBase b = new GCBase();

            Console.WriteLine("GCBase obj Generation is :"+ GC.GetGeneration(b));
            Console.WriteLine("Total memory :" + GC.GetTotalMemory(false));

            GCBase b1 = new GCBase();
            Console.WriteLine("Total memory :" + GC.GetTotalMemory(false));

            Console.ReadKey();
        }
    }
}

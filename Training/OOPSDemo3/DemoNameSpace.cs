using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computer;  // Importing user defined namespace
using Television;

namespace OOPSDemo3
{
    class DemoNameSpace
    {
        static void Main()
        {
            Hardware h1 = new Hardware();
            Hardware1 h2 = new Hardware1();
            h1.test();
            h2.test();
            Console.ReadKey();
        }
    }
}

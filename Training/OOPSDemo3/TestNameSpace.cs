using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    class TestNameSpace
    {
        static void Main()
        {
            Computer.Hardware h1 = new Computer.Hardware();
            Television.Hardware1 h2 = new Television.Hardware1();
            h1.test();
            h2.test();
            Console.ReadKey();
        }
    }
}

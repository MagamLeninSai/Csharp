using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    class SuperClass
    {
        public void display()
        {
            Console.WriteLine("Base Class Display Method");
        }
    }

    class DerivedClass : SuperClass
    {
        public new void display()  // method hiding we use new keyword
        {
            Console.WriteLine("Derived Class Display Method");
        }
    }
    class MethodHidingDemo
    {
        static void Main()
        {
            DerivedClass d = new DerivedClass();
            d.display();
            Console.ReadKey();
        }
    }
}

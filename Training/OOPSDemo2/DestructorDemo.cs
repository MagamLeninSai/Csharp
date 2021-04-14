using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class people
    {
        public people()
        {
            Console.WriteLine("Constructor invoked");
        }
        ~people()
        {
            Console.WriteLine("Destructor invoked");
        }
    }
    class DestructorDemo
    {
        static void Main()
        {
            people p1 = new people();
            people p2 = new people();
            people p3 = new people();
            //Console.ReadKey();
        }
    }
}

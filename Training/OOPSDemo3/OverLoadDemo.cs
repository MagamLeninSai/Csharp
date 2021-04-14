using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    class OverLoadDemo
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void add(string s1, string s2)
        {
            Console.WriteLine(s1 + s2);
        }
        static void Main(string[] args)
        {
            OverLoadDemo obj = new OverLoadDemo();
            obj.add(10, 20);
            obj.add(10.5f, 20.5f);
            obj.add("Micheal", " George");
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}

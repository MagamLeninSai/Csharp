using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    public class StaticDemo
    {
        private static int count;

        public StaticDemo()
        {
            count++;
        }

        public static void display()
        {
            Console.WriteLine("No. of Objects Created :" + count);
        }
    }

    class CountObjects
    {
        static void Main(string[] args)
        {
            StaticDemo s1 = new StaticDemo();
            StaticDemo s2 = new StaticDemo();
            StaticDemo s3 = new StaticDemo();
            StaticDemo s4 = new StaticDemo();

            StaticDemo.display();
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssemblyTest
{
    class Calci
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
        public int Multi(int a, int b)
        {
            return (a * b);
        }
        public int Divide(int a, int b)
        {
            return (a / b);
        }
    }
    class GCExample3
    {
        public static void Main(string[] args)
        {
            Calci oCalci = new Calci();

            // The Collect method used to collect the unreferenced objects in the heap memory.
            Console.WriteLine("Calci object is now on " + GC.GetGeneration(oCalci) + " Generation");
            Console.WriteLine("Garbage Collection Occured in 0th Generation:" + GC.CollectionCount(0));
            Console.WriteLine("Garbage Collection Occured in 1th Generation:" + GC.CollectionCount(1));
            Console.WriteLine("Garbage Collection Occured in 2th Generation:" + GC.CollectionCount(2));
            GC.Collect(0); // force full we are calling garbage-collected
            Console.WriteLine("Garbage Collection Occured in 0th Generation:" + GC.CollectionCount(0));
            Console.ReadKey();
        }
    }
}

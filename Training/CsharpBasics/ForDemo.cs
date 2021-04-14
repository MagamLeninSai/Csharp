using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class ForDemo
    {
        static void Main(String[] args) {
            for (int i = 1; i <= 5; i++) {
                Console.WriteLine("C# For Loop : iteration {0}", i);
            }

            for (int i=0,j=0;i+j<=5;i++,j++) {
                Console.WriteLine("i = {0} and j = {1}", i,j);
            }
            // for loop without Initializations & iterator statement
            int m = 1;
            for (;m<=5;) {
                Console.WriteLine("C# For Loop : iteration {0}", m);
                m++;
            }
            // infinite Loops
            /*for (; ; ) {
                Console.WriteLine("Infinite Loop");
            } */
            Console.ReadKey();
        }
    }
}

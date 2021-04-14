using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int j;
            for (j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }
            int i = 1;
            Console.WriteLine("odd \t even");
            while (i <= 10)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("\t" + i);
                }
                i = i + 1;
            }
            Console.ReadKey();
        }
        
    }
}

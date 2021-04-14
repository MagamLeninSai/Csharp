using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class CommandLineDemo
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            int sum = a + b;
            Console.WriteLine(sum);
                 //OR
            int c = int.Parse(args[0]);
            int d = int.Parse(args[1]);
            int diff = d - c;
            Console.WriteLine(diff);
            Console.ReadKey();
        }
    }
}

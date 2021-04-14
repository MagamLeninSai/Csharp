using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class CheckedDemo
    {
        static void Main()
        {
            checked
            {
                int val = int.MaxValue; // Stores MAX value of int
                Console.WriteLine(val+2); // (RTE),if there is no checked keyword it will show wrong op and unchecked
            }
            Console.ReadLine();
        }
    }
}

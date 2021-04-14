using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class PredicateDemo1
    {
        static void Main(string[] args)
        {
            Predicate<int> dlgt = IsGreaterthanZero;
            bool result = dlgt(10);
            Console.WriteLine("Result: {0}", result);
            Console.ReadLine();
        }

        public static bool IsGreaterthanZero(int a)
        {
            bool i = false;
            if (a > 0)
            {
                i = true;
            }
            return i;
        }
    }
}

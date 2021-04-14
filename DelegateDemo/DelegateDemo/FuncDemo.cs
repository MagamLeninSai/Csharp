using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class FuncDemo
    {
        static Func<int, int, int> operations;
        public static int sum(int x,int y) 
        {
            return x + y;
        }
        public static void Main()
        {
            Func<int, int, int> add = sum;

            int result = add(10,20);
            Console.WriteLine("Sum is :"+result);
            Console.ReadKey();
        }
    }
}

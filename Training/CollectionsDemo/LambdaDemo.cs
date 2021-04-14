using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LambdaDemo
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6};
            List<int> evenNumbers = list.FindAll(x => (x%2) ==0 );
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            var square = list.Select(x => x*x);
            Console.WriteLine("*****Squares*****");
            foreach (var num in square)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqAggregateFun
    {
        static void Main()
        {
            List<int> myIntegerList = new List<int>()
            {
              1,2,3,4,5,6,7,8,9,10
            };
            int m = myIntegerList.Min();
            int n = myIntegerList.Max();
            int s = myIntegerList.Sum();
            double k = myIntegerList.Average();
            int c = myIntegerList.Count();

            /* Aggregate function is useful to perform the operations on each item of the list.
             * The Aggregate() function will perform the action on the first and second elements
             * and then carry forward the result. */

            double sum = myIntegerList.Aggregate((a,b) => a + b);

            Console.WriteLine("The Minimum No. in List is :"+m);
            Console.WriteLine("The Maximum No. in List is :"+n);
            Console.WriteLine("The Sum No. in List is :"+s);
            Console.WriteLine("The Average No. in List is :"+k);
            Console.WriteLine("The Total No. in List is :"+c);
            Console.WriteLine("The Sum of series in List is :"+sum);

            string[] charlist = { "a", "b", "c", "d" };
            var concat = charlist.Aggregate((a, b) => a + ',' + b);
            Console.WriteLine("Concatenated String: {0}", concat);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqDemo
    {
        static void Main()
        {
            // Define LINQ Data Source -
            List<int> myIntegerList = new List<int>()
            {
              1,2,3,4,5,6,7,8,9,10
            };
            // LINQ Query using Query Syntax
            var querySyntax = from i in myIntegerList
                              where i > 5
                              select i;
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqDemo1
    {
        static void Main()
        {
            // Define LINQ Data Source -
            List<int> myIntegerList = new List<int>()
            {
              1,2,3,4,5,6,7,8,9,10
            };

            // LINQ Query using Method Syntax
            var methodSyntax = myIntegerList.Where(i => i>5).ToList();
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            // LINQ Query using Method Syntax
            var mixedSyntax = (from i in myIntegerList
                                 where i > 5
                                 select i).Sum(); 
            Console.WriteLine(mixedSyntax);
            Console.ReadKey();
        }
    }
}

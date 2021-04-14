using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqElementOperators
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int MethodSyntax = numbers.ElementAt(3);
            Console.WriteLine(MethodSyntax);

         //   int MethodSyntax1 = numbers.ElementAt(10);  //RTE  indexRange Exceded
            int MethodSyntax1 = numbers.ElementAtOrDefault(10);  //return 0  indexRange Exceded
            Console.WriteLine(MethodSyntax1);

            int MethodSyntax2 = numbers.First();
            Console.WriteLine(MethodSyntax2);  //Fetch 1ST element

            int MethodSyntax3 = numbers.FirstOrDefault(num => num >50);
            Console.WriteLine(MethodSyntax3);  //Fetch 1ST element > 50 else default 0

            int MethodSyntax4 = numbers.Last();
            Console.WriteLine(MethodSyntax4);  //Fetch last element

            int MethodSyntax5 = numbers.LastOrDefault(num => num < 9);
            Console.WriteLine(MethodSyntax5);  //Fetch last element < 9 else default 0
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqOrderByStrings
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan",
            "Hina","Kumar","Manoj", "Rout", "James"};
            //Using Method Syntax
            var MS = stringList.OrderBy(name => name);
            //Using Query Syntax
            var QS = (from name in stringList
                      orderby name descending 
                      select name).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("____________________");
            foreach (var item in QS)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class ArrayListDemo1
    {
        static void Main()
        {
            ArrayList list = new ArrayList(); 
            list.Add("Manesh");
            list.Add("Akshay");
            list.Add("Vikash");
            list.Add("Anuj");
            list.Add("Dharmesh");
            list.Add("Raman");
            Console.WriteLine("Initial ArrayList Contents :");
            foreach (var v in list) {
                Console.WriteLine(v);
            }
            list.Reverse();
            Console.WriteLine("ArrayList after Reversing :");
            foreach (var v in list)
            {
                Console.WriteLine(v);
            }
            list.Sort();
            Console.WriteLine("ArrayList after Sorthing :");
            foreach (var v in list)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Position of Manesh :" + list.BinarySearch("Manesh")); // must use after sort
            Console.ReadKey();
        }
    }
}

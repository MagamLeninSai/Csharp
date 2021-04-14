using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList(); // intial size is 0

            a.Add("Welcome");
            a.Add(100);
            a.Add(22.2);
            a.Add(true);
            a.Add("Non Generic Collection");

            Console.WriteLine("ArrayList Count :" + a.Count);
            Console.WriteLine("ArrayList Capacity :" + a.Capacity);

            ArrayList b = new ArrayList() { 500, "Hi" };

            //add arraylist b to a
            a.AddRange(b);

            // insert elements into arrayList

            a.Insert(0, "Hello");
            a.Insert(3, 555);

            ArrayList c = new ArrayList() { 111, "Cool" };
            a.InsertRange(2, c); // inserting c arraylist to 2 position in a

            Console.WriteLine("ArrayList Count :" + a.Count);
            Console.WriteLine("ArrayList Capacity :" + a.Capacity);
            Console.WriteLine("************** ArrayList Elements ***********");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            string msg = (string)a[0];  // access elements in arraylist based on index
           

            Console.WriteLine("Element at 0 :" + msg);
            

            // Removing an element which is having a value 20.5f
            a.Remove(20.2f);

            // Removing an element at index 0
            a.RemoveAt(0);

            // Removing 2 elements starting from index 3
            a.RemoveRange(3, 2);
            Console.WriteLine("************** ArrayList Elements after Removal***********");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}



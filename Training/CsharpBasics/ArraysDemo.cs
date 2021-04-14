using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class ArraysDemo
    {
        public static void Main() {
            int[] evenNums = { 2, 4, 6, 8, 10 };
            string[] cities = { "Mumbai", "London", "New York" };
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };
            Console.WriteLine("***Displaying EvenNums Array***\n");
            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

            for (int i = 0; i < evenNums.Length; i++)
                evenNums[i] = evenNums[i] + 10;

            Console.WriteLine("***Displaying EvenNUms Array Added with 10***\n");
            foreach (var item in evenNums)
                Console.WriteLine(item);

            Console.WriteLine("***Displaying Cities***\n");
            foreach (var city in cities)
                Console.WriteLine(city);

            Array.Sort(nums); // sorts array
            Console.WriteLine("***Ascending order***\n");
            foreach (var item in nums)
                Console.WriteLine(item);
            Console.WriteLine("***BinarySearch***\n");
            Console.WriteLine(Array.BinarySearch(nums, 15));// binary search is done after sorting array else we get -1 op

            Console.WriteLine("***Decending order***\n");
            Array.Reverse(nums); // sorts array in descending order
            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
           
            Console.ReadKey();
        }
    }
}

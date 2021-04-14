using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class ArraysDemo1
    {
        public static void Main() {
            int[] singleDimension1 = new int[9];
            int[] singleDimension2 = { 10, 2, 13, 4, 35, 61, 17, 48, 19 };

            int count = singleDimension2.Length;
            Console.WriteLine("The size of Array 2 is :{0}", count);

            int dimension = singleDimension2.Rank;
            Console.WriteLine("The Rank of Array 2 is :{0}", dimension);

            Array.Sort(singleDimension2);

            foreach (int i in singleDimension2)
            {
                Console.WriteLine(i);
            }

            singleDimension2.CopyTo(singleDimension1, 0);

            singleDimension1.SetValue(400, 5);
            Console.WriteLine("********************");
            foreach (int i in singleDimension1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

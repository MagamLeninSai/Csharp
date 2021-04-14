using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class MultyArray
    {
        public static void Main() {
            // Declaring 2D Array
            int[,] a = new int[3,3];
            // initialisation
            a[0, 0] = 100;
            a[1, 1] = 200;
            a[2, 2] = 300;
            // traverse
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Declare & intialisation array
            int[,] b = { {1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The size of 2-d Array is : "+b.Length);
            Console.WriteLine("Dimension of Array is : "+b.Rank);
            int[,] c = new int[5, 10];
            Console.WriteLine("The No of Rows : "+c.GetLength(0)); // 0 means Rows
            Console.WriteLine("The No of columns : "+c.GetLength(1)); // 1 means Columns
            Console.ReadKey();
        }
    }
}

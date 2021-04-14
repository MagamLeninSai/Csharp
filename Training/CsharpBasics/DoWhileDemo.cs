using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class DoWhileDemo
    {
		public static void Main(string[] args)
		{
			int i = 1, n = 5, product;
			do
			{
				product = n * i;
				Console.WriteLine("{0} * {1} = {2}", n, i, product);
				i++;
			} while (i <= 10);
			/*  Infinite While & Do While Loop
			while (true)
			{
				// body of while loop
			}
			do
			{
				// body of while loop
			} while (true);

			*/
			Console.ReadKey();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class MathDemo
    {
        static void Main(string[] args)
        {
            double num = 0;
            double power = 0;
            double result = 0;


            Console.Write("Enter Number : ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Power : ");
            power = Convert.ToDouble(Console.ReadLine());

            result = Math.Pow(num, power);
            Console.WriteLine("Result : " + result);

            result = Math.Sqrt(16);
            Console.WriteLine("Result : " + result);

            result = Math.Max(10.2, 10.5);
            Console.WriteLine("Result : " + result);

            result = Math.Min(10.2, 10.5);
            Console.WriteLine("Result : " + result);

            result = Math.Ceiling(10.2);
            Console.WriteLine("Result : " + result);

            result = Math.Floor(10.2);
            Console.WriteLine("Result : " + result);

            result = Math.Round(10.6);
            Console.WriteLine("Result : " + result);
            Console.ReadKey();
        }
    }
}

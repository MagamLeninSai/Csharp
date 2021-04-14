using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class First
    {
        static void Main(String[] args) {
            int a, b, sum = 0;
            String name;
            decimal Salary;
            double age;
            Console.WriteLine("My First Program in C#");
            Console.WriteLine("Enter ur Name,salary,age:");
            name = Console.ReadLine();
            Salary = Convert.ToDecimal(Console.ReadLine());
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hello {0} with age :{1} ur Salary :{2}",name,age,Salary);

            Console.WriteLine("Arithmetic Operation");
            Console.WriteLine("Enter 2 Numbers :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("The Addition of {0} and {1} is {2}",a,b,sum);
            Console.ReadKey();
        }
    }
}

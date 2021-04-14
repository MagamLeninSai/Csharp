using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class EmployeeTest
    {
        public static void Main() {
            Employee e = new Employee();
            e.input();
            decimal np = e.calculateSalary();
            e.display();
            Console.WriteLine("Net Salary  :"+np);
            Console.WriteLine("===========================");
            Console.ReadKey();
        }
    }
}

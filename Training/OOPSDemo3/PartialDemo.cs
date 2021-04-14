using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    class PartialDemo
    {
        static void Main()
        {
            PartialEmployee emp = new PartialEmployee();
            emp.FirstName = "Lenin";
            emp.LastName = "Sai";
            emp.Salary = 30000;
            emp.Gender = "Male";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}

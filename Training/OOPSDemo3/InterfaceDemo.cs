using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    class InterfaceDemo
    {
        public static void Main()
        {
            Employee emp = new Employee();
            System.Console.Write("Enter employee ID: ");
            emp.empID = int.Parse(System.Console.ReadLine());
            Console.Write("Enter the name of the employee: ");
            emp.empname = System.Console.ReadLine();
            System.Console.WriteLine("The employee information:");
            System.Console.WriteLine("Employee ID: {0}", emp.empID);
            System.Console.WriteLine("Employee name: {0}", emp.empname);
            Console.ReadLine();
        }
    }
}

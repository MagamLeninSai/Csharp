using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class EmployeeTest
    {
        public static void Main() {
            int i = 10;
            bool r = i.IsGreaterThan(100); //Extension method in ExtensionDemo Class
            Console.WriteLine(r);
            Employee e = new Employee();
            e.GetBranchData();
            e.GetEmployeeData();
            e.DisplayBranchData();
            e.DisplayEmployeeData();
            Console.ReadKey();
        }
    }
}

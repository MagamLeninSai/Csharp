using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryLib;

namespace MyAssemblyTest
{
    class Employee
    {
        int empId;
        String name;
        String desig;
        long basic;

        public int EmpId { get => empId; set => empId = value; }
        public string Name { get => name; set => name = value; }
        public string Desig { get => desig; set => desig = value; }
        public long Basic { get => basic; set => basic = value; }

        static void Main()
        {
            Employee e = new Employee();
            MySalary s = new MySalary();
            e.EmpId = 101;
            e.Name = "Lenin";
            e.Desig = "Developer";
            e.Basic = 10000;
            double netSal = s.CalculateSal(e.Basic);

            Console.WriteLine(e.EmpId +" "+e.Name +" "+e.Desig +" "+e.Basic +" "+netSal);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class GListComplex
    {
        static void Main()
        {
            // Create Employee Objects
            Employee emp1 = new Employee()
            {
                Id = 101,
                Name = "Lenin",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                Id = 102,
                Name = "Mary",
                Gender = "Female",
                Salary = 7000
            };
            Employee emp3 = new Employee()
            {
                Id = 103,
                Name = "Mike",
                Gender = "Male",
                Salary = 5500
            };
            Employee emp4 = new Employee()
            {
                Id = 104,
                Name = "Ravi",
                Gender = "Male",
                Salary = 6500
            };

            List<Employee> l = new List<Employee>();
            l.Add(emp1);
            l.Add(emp2);
            l.Add(emp3);
            Console.WriteLine("*********ListEmployes in list***********");
            foreach (Employee e in l)
            {
                Console.WriteLine(e.Id+" "+e.Name+" "+e.Gender+" "+e.Salary);
            }

            Employee emp = l[0];
            Console.WriteLine();
            Console.WriteLine("Retrive the First employee by index");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
                     emp.Id, emp.Name, emp.Gender, emp.Salary);

            l.Insert(1,emp4);
            Console.WriteLine();
            Console.WriteLine("**********Display new List************");
            for (int i=0;i<l.Count;i++)
            {
                Employee e = l[i];
                Console.WriteLine(e.Id+" "+e.Name+" "+e.Gender+" "+e.Salary);
            }
            Console.ReadKey();
        }
    }
}

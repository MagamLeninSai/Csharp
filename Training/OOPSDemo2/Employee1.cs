using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class Human
    {
        public string name;
        public Human(string na)
        {
            name = na;
        }
    }

    class Man : Human
    {
        public int age;
        public Man(int age, string name) : base(name)
        {
            this.age = age;
        }
    }

    class Employee1 : Man
    {
        public int emp_id;
        public int emp_salary;

        public Employee1(int id, int salary, string name, int age) : base(age, name)
        {
            emp_id = id;
            emp_salary = salary;
        }
        public void Print()
        {
            Console.WriteLine("Emp ID:      " + emp_id);
            Console.WriteLine("Emp Name:    " + name);
            Console.WriteLine("Emp Salary:  " + emp_salary);
            Console.WriteLine("Emp Age:     " + age);
        }
        static void Main(string[] args)
        {
            Employee1 emp = new Employee1(101, 1000, "Rahul", 31);
            emp.Print();
            Console.ReadKey();
        }
    }
}

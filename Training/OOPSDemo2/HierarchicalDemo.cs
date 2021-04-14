using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class person
    {
        protected String name;
        protected int age;

        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void printPerson()
        {
            Console.WriteLine("Name      :" + name);
            Console.WriteLine("Age       :" + age);
        }
    }
    class Staff : person
    {
        protected int staff_id;
        protected long Staff_salary;

        public Staff(int staff_id, long staff_salary,String name,int age) : base(name, age)
        {
            this.staff_id = staff_id;
            Staff_salary = staff_salary;
        }
        public void printStaff() {
            Console.WriteLine("Staff Id        :"+staff_id);
            base.printPerson();
            Console.WriteLine("Staff Salary    :"+ Staff_salary);
        }
    }
    class Student:person
    {
        protected int rollno;
        protected double fees;

        public Student(int rollno, double fees,String name,int age) : base(name,age)
        {
            this.rollno = rollno;
            this.fees = fees;
        }
        public void printStudent()
        {
            Console.WriteLine("Student RollNo    :" + rollno );
            base.printPerson();
            Console.WriteLine("Student Fees      :" + fees);
        }
    }
    class HierarchicalDemo
    {
        static void Main() {
            Staff s = new Staff(1001,5000,"Lenin",30);
            Student s1 = new Student(100, 30000, "Sai",20);
            s.printStaff();
            s1.printStudent();
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    class Employee100
    {
        private string _firstName;
        private string _lastName;
        private double _salary;
        private string _gender;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public double Salary { get => _salary; set => _salary = value; }
        public string Gender { get => _gender; set => _gender = value; }

        public void DisplayFullName()
        {
            Console.WriteLine("Full Name is : {0} {1}", _firstName, _lastName);
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine("First Name : {0}", _firstName);
            Console.WriteLine("Last Name : {0}", _lastName);
            Console.WriteLine("Gender : {0}", _gender);
            Console.WriteLine("Salary : {0}", _salary);
        }

        static void Main() {
            Employee100 emp = new Employee100();
            emp.FirstName = "Raj";
            emp.LastName = "gs";
            emp.Salary = 100000;
            emp.Gender = "Male";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}

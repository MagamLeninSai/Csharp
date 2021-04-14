using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class Employee : Branch 
    {
        int EmployeeId, EmployeeAge;
        string EmployeeName, EmployeeAddress;
        public Employee() {
            Console.WriteLine("Employee COnstructor");
        }
        public void GetEmployeeData()
        {
            Console.WriteLine("ENTER EMPLYEE DETAILS:");
            Console.WriteLine("ENTER EMPLOYEE ID");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE AGE");
            EmployeeAge = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE NAME");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOYEE ADDRESS");
            EmployeeAddress = Console.ReadLine();
        }
        public void DisplayEmployeeData()
        {
            Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
            Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
            Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
            Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
        }
    }
}

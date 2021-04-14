using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class linqJoin
    {
        static void Main()
        {
            var JoinUsingMS = Employee1.GetAllEmployees() //Outer Data Source
                           .Join(
                           Address.GetAllAddresses(),  //Inner Data Source
                           employee => employee.AddressId, //Inner Key Selector
                           address => address.ID, //Outer Key selector
                           (employee, address) => new //Projecting the data into a result set
                           {
                               EmployeeName = employee.Name,
                               AddressLine = address.AddressLine
                           }).ToList();

            Console.WriteLine("Name \t\t Address");
            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine(employee.EmployeeName + "\t\t" + employee.AddressLine);
            }

            var JoinUsingQS = (from emp in Employee1.GetAllEmployees()
                               join address in Address.GetAllAddresses()
                               on emp.AddressId equals address.ID
                               select new
                               {
                                   EmployeeName = emp.Name,
                                   AddressLine = address.AddressLine
                               }).ToList();
            foreach (var employee in JoinUsingQS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
            Console.ReadLine();
        }
    }
    
}

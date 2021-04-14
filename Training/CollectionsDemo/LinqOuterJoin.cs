using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqOuterJoin  //LeftJOin
    {
        static void Main(string[] args)
        {
            var MSOuterJOIN = Employee1.GetAllEmployees()
                              .GroupJoin(
                                    Address.GetAllAddresses(),
                                    emp => emp.AddressId,
                                    add => add.ID,
                                    (emp, add) => new { emp, add }
                              )
                              .SelectMany(
                                    x => x.add.DefaultIfEmpty(),
                                    (employee, address) => new { employee, address }
                               );
            foreach (var item in MSOuterJOIN)
            {
                Console.WriteLine($"Name : {item.employee.emp.Name}, Address : {item.address?.AddressLine} ");
            }
            Console.ReadLine();
        }
    }
}

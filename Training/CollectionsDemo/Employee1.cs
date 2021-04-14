using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Employee1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public static List<Employee1> GetAllEmployees()
        {
            return new List<Employee1>()
            {
                new Employee1 { ID = 1, Name = "Preety", AddressId = 1 },
                new Employee1 { ID = 2, Name = "Priyanka", AddressId = 2 },
                new Employee1 { ID = 3, Name = "Anurag", AddressId = 3 },
                new Employee1 { ID = 4, Name = "Pranaya", AddressId = 4 },
                new Employee1 { ID = 5, Name = "Hina", AddressId = 5 },
                new Employee1 { ID = 6, Name = "Sambit", AddressId = 6 },
                new Employee1 { ID = 7, Name = "Happy", AddressId = 7},
                new Employee1 { ID = 8, Name = "Tarun", AddressId = 8 },
                new Employee1 { ID = 9, Name = "Santosh", AddressId = 9 },
                new Employee1 { ID = 10, Name = "Raj", AddressId = 10},
                new Employee1 { ID = 11, Name = "Sudhanshu", AddressId = 11}
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    class Employee : IEmployee
    {
        int id;
        String name;
        public int empID { get => id; set => id = value; }
        public string empname { get => name; set => name = value; }
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    class PartialCustomer
    {
        static void Main()
        {
            Customer customer = new Customer();
            customer.Amount = 2000;
            Console.WriteLine("Current balance is: " + customer.Amount);
            customer.depositAmount(1000);
            // Accessing seperate file function
            customer.withdraw(500);
            Console.ReadKey();
        }
    }
}

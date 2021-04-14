using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    public partial class Customer
    {
        int amount;
        public void depositAmount(int d_amount)
        {
            amount += d_amount;
            Console.WriteLine(d_amount + " amount is deposited");
            Console.WriteLine("Available balance is: " + amount);
        }
    }
}

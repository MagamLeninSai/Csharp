using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    public partial class Customer
    {
        public int Amount { get { return amount; } set { amount = value; } }

        public void withdraw(int w_amount)
        {
            amount -= w_amount;
            Console.WriteLine(w_amount + " is withdrawn");
            Console.WriteLine("Available balance is: " + amount);
        }

    }
}

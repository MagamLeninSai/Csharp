using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    sealed public class Bank
    {
        public void deposit()
        {
            Console.WriteLine("Depositing Amount");
        }
    }
    public class CoopBank // : Bank  //CTE cannot inherit bcz of sealed class
    {
        public void pigmydeposit()
        {
            Console.WriteLine("Depositing pigmy Amount");
        }
    }
    class SealedClassDemo
    {
        static void Main()
        {
            CoopBank c = new CoopBank();
            c.pigmydeposit();
            Bank b = new Bank();
            b.deposit();
            Console.ReadKey();
        }
    }
}

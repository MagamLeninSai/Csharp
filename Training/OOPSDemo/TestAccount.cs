using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace OOPSDemo
{
    class TestAccount
    {
        static void Main(string[] args)
        {
            // using Reference-MyClassLibrary(namespace/dll file)-changeCharactor(Class)-methods
            ChangeCharacter c = new ChangeCharacter();
           
            //create an instance of Account
            Account objAccount = new Account(1000);
            Console.WriteLine(c.UpperCase("After creating account :"));
            objAccount.ShowBalance();

            objAccount.deposit(5000);
            Console.WriteLine(c.LowerCase("After depositing amount :"));
            objAccount.ShowBalance();

            objAccount.withdraw(1700);
            Console.WriteLine("After withdrawing :");
            objAccount.ShowBalance();
            Console.ReadKey();
        }
    }
}

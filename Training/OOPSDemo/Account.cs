using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Account
    {
        private int _balance;

        //default constructor		
        public Account()
        {
            _balance = 2000;
        }

        //parameterized constructor

        public Account(int bal)
        {
            _balance = bal;
        }

        public void deposit(int depositAmt)
        {
            _balance = _balance + depositAmt;

        }

        public void withdraw(int withAmt)
        {
            //to check if funds in the balance are large 
            //enough to permit withdrawals

            if (withAmt < (_balance - 2000))
            {
                _balance = _balance - withAmt;
            }
            else
                Console.WriteLine("Insufficient funds...cannot withdraw");
        }

        public void ShowBalance()
        {
            Console.WriteLine("Current Balance is : " + _balance);
        }
    }
}

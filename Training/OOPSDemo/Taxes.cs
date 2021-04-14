using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Taxes
    {
        // This method only takes one argument: the personal income amount
        public double ComputeTax(double amt)
        {
            double taxRate = 0.15;
            double taxAmt = 0;

            taxAmt = amt * taxRate;
            Console.WriteLine("\nCalculated tax for personal income is {0}", taxAmt);
            return taxAmt;
        }

        // This method only takes an amount and a rate as arguments 
        // and is used in the cases when a person owns either a home or a business
        public double ComputeTax(double amt1, double rate1, string str)
        {
            double taxAmt;

            taxAmt = amt1 * (rate1 / 100);
            //in case the person owns a home display appropriate message for the same
            if (str == "home")
                Console.Write("\nCalculated tax based on home rate and home value is ");

            //in case the person owns a business
            else if (str == "business")
                Console.Write("\nCalculated tax based on business rate and sales is ");

            //display the calculated tax amount for either case
            Console.WriteLine(taxAmt);
            return taxAmt;
        }

        // This method takes two amounts and two rates as arguments 
        // and is used in the cases when a person owns both a home as well as a business
        public double ComputeTax(double amt1, double rate1, double amt2,
            double rate2)
        {
            double taxAmt;
            taxAmt = (amt1 * rate1 / 100) + (amt2 * rate2 / 100);
            Console.WriteLine("\nCalculated tax based on home value, home rate,gross sales, gross rate is {0}", taxAmt);
            return taxAmt;
        }
    }
}

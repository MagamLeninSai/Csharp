using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class TestTaxes
    {
        static void Main(string[] args)
        {
            Taxes objTaxes = new Taxes();

            bool ownsHome = false;
            bool ownsBusiness = false;
            string choice;
            double homeTaxRate = 0, homeValue = 0;
            double grossSalesRate = 0;
            double grossSales = 0;
            double personalIncome = 0;
            double totalTax = 0;
            double taxRate = 0;

            Console.WriteLine("Do you own a home? (y/n)");
            choice = Console.ReadLine();
            if (choice == "y")
            {
                ownsHome = true;
                Console.WriteLine("What is its value?");
                choice = Console.ReadLine();
                homeValue = Convert.ToDouble(choice);
                Console.WriteLine("What is the home tax rate?");
                choice = Console.ReadLine();
                homeTaxRate = Convert.ToDouble(choice);
            }

            Console.WriteLine("Do you own a business? (y/n)");
            choice = Console.ReadLine();
            if (choice == "y")
            {
                ownsBusiness = true;
                Console.WriteLine("What was your total sales?");
                choice = Console.ReadLine();
                grossSales = Convert.ToDouble(choice);
                Console.WriteLine("What is the gross sales tax rate?");
                choice = Console.ReadLine();
                grossSalesRate = Convert.ToDouble(choice);
            }

            if (ownsHome && !ownsBusiness)
            {

                totalTax = objTaxes.ComputeTax(homeValue, homeTaxRate, "home");
            }
            else if (!ownsHome && ownsBusiness)
            {

                totalTax = objTaxes.ComputeTax(grossSales, grossSalesRate, "business");
            }
            else if (ownsHome && ownsBusiness)
                totalTax = objTaxes.ComputeTax(homeValue, homeTaxRate, grossSales, grossSalesRate);

            Console.WriteLine("How much salary did you earn last year?");
            choice = Console.ReadLine();
            personalIncome = Convert.ToDouble(choice);

            totalTax = totalTax + objTaxes.ComputeTax(personalIncome);
            Console.WriteLine("Total tax is {0}", totalTax);

            taxRate = 0.15;
            Console.WriteLine("Personal tax rate is {0}", taxRate);

        }
    }
}

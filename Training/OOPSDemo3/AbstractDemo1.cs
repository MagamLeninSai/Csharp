using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//In the below example, we calculate the electricity bills for commercial and domestic plans
//using abstract class and abstract methods
namespace OOPSDemo3
{
    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate(); // abstract methods
        public void calculation(int units)
        {
            double  bill = rate * units;
            Console.WriteLine("Bill Amount For {0} Units is :{1}",units ,bill );
        }
    }
    class Commercial : Plan
    {
        public override void getRate()
        {
            rate = 5.00;
            
        }
    }
    class Domestic : Plan
    {
        public override void getRate()
        {
            rate = 2.50;
        }
    }
    class AbstractDemo1
    {
        static void Main()
        {
            Plan p;
            Console.WriteLine("COMMERCIAL CONNECTION");
            p = new Commercial();
            p.getRate();
            p.calculation(250);
            Console.WriteLine("DOMESTIC CONNECTION");
            p = new Domestic();
            p.getRate();
            p.calculation(250);
            Console.ReadKey();
        }
    }
}

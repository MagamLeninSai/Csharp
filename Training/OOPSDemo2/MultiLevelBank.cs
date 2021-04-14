using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class RBI
    {
        const float RATE_RBI = 6.7f;
        public float calculateBalanceRBI(int amount,int year) {
            return amount +((amount* RATE_RBI *year)/100);
        }
    }
    class SBI : RBI {
        const float RATE_SBI = 7f;
        public float calculateBalanceSBI(int amount, int year)
        {
            return amount + ((amount * RATE_SBI * year) / 100);
        }

    }
    class Canara:SBI
    {
        const float RATE_CANARA = 7.2f;
        public float calculateBalanceCANARA(int amount, int year)
        {
            return amount + ((amount * RATE_CANARA * year) / 100);
        }
    }
    class MultiLevelBank {
        public static void Main() {
            Canara c = new Canara();
            Console.WriteLine("Enter the Amount you Want to invest :");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Specifiy Duration in years");
            int years=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maturity Amount as per Canara Bank : "+c.calculateBalanceCANARA(amount ,years));
            Console.WriteLine("Maturity Amount as per SBI Bank : " + c.calculateBalanceSBI(amount, years));
            Console.WriteLine("Maturity Amount as per RBI Bank : " + c.calculateBalanceRBI(amount, years));
            Console.ReadKey();
        }
    }
}

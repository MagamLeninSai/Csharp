using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    /* Ternary operator are a substitute for if...else statement.

    Syntax : Condition ? Expression1 : Expression2;
   */

    class TernaryDemo
    {
        public static void Main() {
            int i = 2,j=2;
            String a,b;
            bool isEven;

            b = (i>j) ? "I is greater than J" : (i<j) ?  "I is Lesser than J"
                :"I is Equal to J";
            Console.WriteLine(b);

            isEven = (i % 2 == 0) ? true : false;
            Console.WriteLine(isEven);

            a = (i % 2 == 0) ? "Even No" : "Odd No";
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}

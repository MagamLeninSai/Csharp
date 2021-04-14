using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class SqrtPreCalculate
    {
        public const int MAX_VALUE = 10000;
        private static int[] sqrtValues;
         static SqrtPreCalculate() {
            sqrtValues = new int[MAX_VALUE + 1];
            for (int i=0;i<sqrtValues.Length;i++) {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
         }
        public static int getSqrt(int value){
            return sqrtValues[value];
        }

        static void Main() {
            Console.WriteLine(getSqrt(9));
            Console.ReadKey();
        }
    }
}

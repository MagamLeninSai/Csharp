using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate double RectDelegate(double width, double height);
    class AnonymousMethod
    {
        static void Main()
        {
            // Instatiation the delegate using Anonymous Method
            RectDelegate r1 = delegate (double width, double height) {
                return width * height;
            };

            //invoking delegate
            Console.WriteLine("Area of Recatangle is : {0}",r1.Invoke(10,20));
            Console.ReadKey();
        }
    }
}

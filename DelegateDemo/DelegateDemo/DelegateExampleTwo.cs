using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    // Step-1: Define a delegate
    public delegate double AreaDelegate(double width, double height);

    public class Rectangle
    {
        public static double CalculateArea(double width, double height)
        {
            return (width * height);
        }
    }

    class DelegateExampleTwo
    {
        static void Main(string[] args)
        {
            //Step-2: Instantiating the delegate
            AreaDelegate area = new AreaDelegate(Rectangle.CalculateArea);
            // OR
            //Step-3: Binding method to delegate instance
            AreaDelegate area1 = Rectangle.CalculateArea;

            // Step-3: Invoking the Delegate by using invoke method
            Console.WriteLine("Using invoke method");
            Console.WriteLine("Area of Rectangle is {0}", area.Invoke(10.10, 20.10));
            // OR
            Console.WriteLine("-------------------------------------------------");
            // Step-3: Invoking the Delegate without using the invoke method
            Console.WriteLine("Without using invoke method");
            Console.WriteLine("Area of Rectangle is {0} ", area1(10.10, 20.10));
            Console.ReadLine();
        }
    }

}

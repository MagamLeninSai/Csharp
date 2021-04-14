using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate double RectangleDelegate(double width,double height);
    class Rectangle1
    {
        public static double CalculateArea(double width,double height)
        {
            return (width * height);
        }
        public static double CalculatePerimeter(double width, double height)
        {
            return 2 *(width + height);
        }
    }
    class MultiCastDemo
    {
        static void Main()
        {
            // instatiation multi cast Delegate
            RectangleDelegate rect = new RectangleDelegate(Rectangle1.CalculateArea);
             rect += Rectangle1.CalculatePerimeter;

            //Step-3: Invoking the Delegate by using invoke method
            Console.WriteLine("Area of Rectangle is {0}", rect.Invoke(10.10, 20.10));
            Console.WriteLine("Perimeter of Rectangle is {0}", rect.Invoke(11.10, 21.22));
            Console.ReadLine();
        }
    }
}

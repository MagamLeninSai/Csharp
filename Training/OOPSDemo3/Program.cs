using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    public interface IArea
    {
        void area(double a, double b);
    }
    class Rectangle : IArea
    {
        public void area(double a, double b)
        {
            double r;
            r = a * b;
            Console.WriteLine("Area of Rectangle is :"+r);
        }
    }
    class Circle : IArea
    {
        static double PI = 3.14;
        public void area(double a, double b)
        {
            double r;
            r = PI * a * a;
            Console.WriteLine("Area of Circle is :" + r);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IArea a = new Rectangle();
            a.area(10,5);
            a = new Circle();
            a.area(4,0);
            Console.ReadKey();
        }
    }
}

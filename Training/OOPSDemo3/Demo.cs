using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    interface Car
    {
        void Drive();
    }
    interface Bus
    {
        void Drive();
    }
    class Demo : Car, Bus
    {
        void Car.Drive()
        {
            Console.WriteLine("Drive Car");
        }
        void Bus.Drive()
        {
            Console.WriteLine("Drive Bus");
        }
        static void Main()
        {
            Demo DemoObject = new Demo();
            ((Car)DemoObject).Drive();
            ((Bus)DemoObject).Drive();

                 //OR
            Car c = new Demo();
            c.Drive();
            Bus b = new Demo();
            b.Drive();

            Console.ReadKey();
        }
    }
}

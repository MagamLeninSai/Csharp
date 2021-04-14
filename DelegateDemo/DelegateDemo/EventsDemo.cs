using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //publisher class
    class Add
    {
        public delegate void dgOdd();  // Declare Delegate
        public event dgOdd evOdd;  // Declare Event

        public void Sum()
        {
            int result = 9;
            Console.WriteLine(result);
            // Check id result is odd number an event should be raised
            if((result % 2 !=0) && (evOdd != null))
            {
                evOdd(); //Raise Event
            }
        }
    }
    // Subscriber Class
    class EventsDemo
    {
        static void Main()
        {
            Add a = new Add();
            // event get binded with delegate
            a.evOdd += new Add.dgOdd(EvenMessage);
            a.Sum();
            Console.ReadKey();
        }
        //delegate calls this event when event raised
        private static void EvenMessage()
        {
            Console.WriteLine("Event Fired.. !! Result is Odd Number");
        }
    }
}

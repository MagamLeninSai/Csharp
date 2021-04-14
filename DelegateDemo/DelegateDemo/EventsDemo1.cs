using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class EventsDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Events Example****");
            Operations op = new Operations(20, 10);
            op.AddOperation();
            op.SubOperation();
            Console.ReadLine();

        }
    }
}

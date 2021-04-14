using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Operations
    {
        Math m;
        public int a { get; set; }
        public int b { get; set; }

        public Operations(int x,int y)
        {
            m = new Math();
            //Subscriber to sample event
            m.SampleEvent += SampleEventHandler;
            a = x;
            b = y;
        }
        // SampleEvent Handler
        public void SampleEventHandler()
        {
            Console.WriteLine("SampleEvent Handler: Calling Method");
        }
        public void AddOperation()
        {
            m.Add(a, b);
        }
        public void SubOperation()
        {
            m.Subtract(a, b);
        }
    }
}

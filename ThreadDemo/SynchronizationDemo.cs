using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Printer
    {
        public void PrintTable()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(Thread.CurrentThread.Name +" - "+i);
                }
            }
        }
    }
    class SynchronizationDemo
    {
        static void Main()
        {
            Printer p = new Printer();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable)) { Name ="Thread1"};
            Thread t2 = new Thread(new ThreadStart(p.PrintTable)) { Name ="Thread2"};
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}

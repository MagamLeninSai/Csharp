using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class MultiThreadDemo
    {
        static void Printinfo1()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("i Value :{0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("First Method Completed");
        }
        static void Printinfo2()
        {
            for (int i=0;i<=4;i++)
            {
                Console.WriteLine("i Value :{0}",i);
            }
            Console.WriteLine("Second Method Completed");
        }
        public static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(Printinfo1));
            Thread t2 = new Thread(new ThreadStart(Printinfo2));
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}

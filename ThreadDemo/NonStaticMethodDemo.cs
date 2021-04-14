using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Employee
    {
        public void display() {
            
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" - "+i);
            }
        }
    }
    class NonStaticMethodDemo
    {
        static void Main() {
            Employee e = new Employee();
            Thread t1 = new Thread(new ThreadStart(e.display)) 
            { 
                Name = "Thread1"
            };
            Thread t2 = new Thread(new ThreadStart(e.display)) 
            {
                Name = "Thread2"
            };
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}

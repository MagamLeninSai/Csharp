using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class ReadOnlyDemo
    {
        private readonly String name="Lenin";  // readonly is like constant fix through out program 
        private readonly String location;
        private readonly int age;
        // initialise in constructors only or else it is like normal variable
        public ReadOnlyDemo() {
           // name = "Lenin";
            location = "Hyd";
            age = 21;
        }
       
        public void display() { 
            Console.WriteLine(name +" "+location +" "+age );
        }
        static void Main() 
        {
            ReadOnlyDemo r = new ReadOnlyDemo();
            r.display();
            Console.ReadKey();
            
        } 

    }
}

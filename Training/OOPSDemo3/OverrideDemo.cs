using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    public class Developer
    {
        public virtual void getInfo()  // virtual method mean it can be overriden
        {
            Console.WriteLine("I am Team Leader");
        }
    }
    public class CSharpDeveloper : Developer 
    {
        public override void getInfo()  // method overrided
        {
            Console.WriteLine("I am C# Developer");
        }
    }
    class OverrideDemo
    {
        static void Main()
        {
            CSharpDeveloper c1 = new CSharpDeveloper();
            c1.getInfo();
            Developer d1 = new Developer();
            d1.getInfo();
            Console.ReadKey();
        }
    }
}

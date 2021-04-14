using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    class Software
    {
        public void update()
        {
            Console.WriteLine("Software Updating..........");
        }
        public void install()
        {
            Console.WriteLine("Software Installing..........");
        }
    }
    class ApplicationSoftware : Software
    {
        public new void install()  // method hiding
        {
            Console.WriteLine("Application Software Installing..........");
        }
        public void run()
        {
            Console.WriteLine("Application Software Run..........");
        }
    }
     class SystemSoftware : Software
    {
        public void run()
        {
            Console.WriteLine("System Software Run..........");
        }
    }
    class MethodHidingDemo1
    {
        public static void Main()
        {
            ApplicationSoftware s1 = new ApplicationSoftware();
            s1.install();          
            s1.update();
            s1.run();

            SystemSoftware s2 = new SystemSoftware();
            s2.install();
            s2.update();
            s2.run();

            Console.ReadKey();
        }

    }
}

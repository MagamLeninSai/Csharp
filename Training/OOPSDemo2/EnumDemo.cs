using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class EnumDemo
    {
        enum colors {Red,Green,Blue }; //Declaring Enum
        enum colors1 { Red=10, Green, Blue }; // Declaring and intializing 
        enum days {Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        enum Emp { pacino, spacey, crowe, pitt, jolie};
         
        static void Main()
        {
            Console.WriteLine("Red   :{0}", (int)colors.Red);
            Console.WriteLine("Green :{0}", (int)colors.Green);
            Console.WriteLine("Blue  :{0}",(int)colors.Blue);

            Console.WriteLine("Red   :{0}", (int)colors1.Red);
            Console.WriteLine("Green :{0}", (int)colors1.Green);
            Console.WriteLine("Blue  :{0}", (int)colors1.Blue);

            // travers the enum using GetValues
            foreach (days d in Enum.GetValues(typeof(days))) {
                Console.WriteLine(d);
            }
            foreach (Emp e in Enum.GetValues(typeof(Emp)))
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}

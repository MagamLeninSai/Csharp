using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class SingleInheretanceDemo
    {
        static void Main() {
            Mamal m = new Mamal(5);
            Console.WriteLine(m.Age);
            m.Sleep();
            Dog d = new Dog("Bulldog",3);
            d.Sleep();
            d.Age = 4;
            Console.WriteLine("Age :{0}",d.Age);
            Console.WriteLine("Breed :{0}",d.Breed);
            d.WagTail();
            Console.ReadKey();
        }
    }
}

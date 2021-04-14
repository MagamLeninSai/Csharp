using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    public class Animal
    {
        public virtual void eat(){ Console.WriteLine("Eating......."); }
        public virtual void run() { Console.WriteLine("Running......"); }

    }
    public class Dog : Animal 
    {
        public override void eat() { Console.WriteLine("Eating Bone......"); }
        public sealed override  void run() { Console.WriteLine("Running Fast....."); }
    }
    public class BabyDog : Dog
    {
        public override void eat() { Console.WriteLine("Eating Biscuits......"); }
        //public override void run() { Console.WriteLine("Running slow....."); } //CTE bcz it is sealed (like Final in java)
    }
    class SealedMethodDemo
    {
        static void Main()
        {
            BabyDog d = new BabyDog();
            d.eat();
            d.run();
            Console.ReadKey();
        }

    }
}

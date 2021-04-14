using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Program
    {
        public static void Main() {
            Console.WriteLine("Enter First Dog's name :");
            String dogName = Console.ReadLine();
            Console.WriteLine("Enter first dog's breed :");
            String dogBreed= Console.ReadLine();

            // using the Dog Constructor to set name and breed
            Dog firstDog = new Dog(dogName,dogBreed);
            firstDog.sayBau();
            Dog secondDog = new Dog();
            secondDog.sayBau();

            Console.WriteLine("Enter second Dogs name :");
            dogName= Console.ReadLine();
            Console.WriteLine("Enter second Dogs breed :");
             dogBreed = Console.ReadLine();

            //Using properties to set name and breed
            secondDog.Name = dogName;
            secondDog.Breed = dogBreed;
            Console.WriteLine(secondDog.Name +" "+ secondDog.Breed);
            Console.ReadKey();
        }
    }
}

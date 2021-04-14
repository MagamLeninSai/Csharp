using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Dog
    {
        string name;
        int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
    class LambdaDemo1
    {
        static void Main()
        {
            List<Dog> dogs = new List<Dog>() 
            {
                new Dog{Name ="Rex",Age =4 },
                new Dog{Name ="Sean",Age =1 },
                new Dog{Name ="Stacy",Age =3 },
            };

            var names = dogs.Select(x=>x.Name);
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}

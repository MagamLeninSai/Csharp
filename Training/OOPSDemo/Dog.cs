using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Dog
    {
        private String name;
        private String breed;

        public Dog()
        {
            this.name = "Balkan";
            this.breed = "Street Excellent";
        }

        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
        // defining properties for the fields with getters and setters
        public string Name { 
            get { return name; } 
            set { name = value; } 
        }
        public string Breed {
            get { return breed; }
            set { breed = value; }
        }
        public void sayBau() {
            Console.WriteLine("{0} , with breed {1} said : Bauuuuuuuuu", name,breed);
        }
    }
}

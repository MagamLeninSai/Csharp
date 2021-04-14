using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class Address {
        public  String street, city, state;

        public Address(string street, string city, string state)
        {
            this.street = street;
            this.city = city;
            this.state = state;
        }
    }

    class Pupil
    {
        int rollno;
        String name;
        static int batch = 2020;
        static string course = "BTech";
        Address addr;

        public Pupil(int rollno, string name, Address addr)
        {
            this.rollno = rollno;
            this.name = name;
            this.addr = addr;
        }
        public void display()
        {
            Console.WriteLine(name+" "+rollno+" "+ addr.street +" "+ addr.city +" "+ addr.state+" "+batch +" "+course );
        }
    }
    class AggregationDemo
    {
        static void Main()
        {
            Address a = new Address("Indira Nagar", "Bengaluru","Karnataka");
            Pupil p = new Pupil(100,"Lenin",a);
            p.display();
            Console.ReadKey();
        }
    }
}

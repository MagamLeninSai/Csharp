using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Student
    {
        private int rollno;
        private String name;
        private String course;
        private String city;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;   
        }
        // Auto implemented Property
        public string City { get; set; }
        public int Rollno { get { return rollno; } } // read only propertys
        public string Name { get { return name; } }

        public string Course { set { course = value; } }//write only

        public void display() {
            Console.WriteLine(course);
        }
    }
}

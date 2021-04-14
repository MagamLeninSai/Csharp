using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Student
    {
       private  int rollno;
       private  String name;
       private  int marks;

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public int Marks { get => marks; set => marks = value; }
    }
    class SelectionDemo
    {
        static void Main()
        {
            List<Student> lstStudent = new List<Student>()
            {
                new Student() { Rollno = 1, Name = "Mike", Marks = 500 },
                new Student() { Rollno = 2, Name = "John", Marks = 300 },
                new Student() { Rollno = 3, Name = "Mary", Marks = 400 },
                new Student() { Rollno = 4, Name = "Ravi", Marks = 550 },
                new Student() { Rollno = 5, Name = "Raj", Marks = 600 },
                new Student() { Rollno = 6, Name = "Pavi", Marks = 700 },
                new Student() { Rollno = 7, Name = "Prasad", Marks = 550 }
            };

            var result = from s in lstStudent
                         where s.Marks >= 500
                         select new { roll = s.Rollno, name = s.Name, m = s.Marks };
            foreach (var i in result)
            {
                Console.WriteLine(i.roll +" "+i.name+" "+i.m);
            }
            Console.ReadKey();
        }
    }
}

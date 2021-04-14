using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class StudentDemo
    {
        public static void Main()
        {
            Student s = new Student(101, "Lenin");
            /*s.Name = "Lenin"; //CTE Read only
            s.Rollno = 100; */
            Console.WriteLine(s.Name +" "+s.Rollno);
            s.Course = "C#";
          //  Console.WriteLine(s.Course); //CTE write only
            s.display();
            s.City = "Hyd";
            Console.WriteLine(s.City);
           Console.ReadKey();
        }
    }
}

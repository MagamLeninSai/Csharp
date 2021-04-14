using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqStudent1OrderBy
    {
        static void Main()
        {
            //Method Syntax
            var MS = Student1.GetAllStudents().OrderBy(x => x.Branch).ToList();
            var MS1 = Student1.GetAllStudents().
                      Where (std => std.Branch.ToUpper() == "CSE").
                      OrderBy(x => x.FirstName).ToList();
            //Query Syntax
            var QS = (from std in Student1.GetAllStudents()
                    //  where std.Branch.ToUpper() == "CSE"
                      orderby std.FirstName
                      select std);
            foreach (var student in MS)
            {
                Console.WriteLine(" Branch: " + student.Branch + ", Name :" + student.FirstName + " " + student.LastName);
            }
            Console.WriteLine("___________________________________");
            foreach (var student in MS1)
            {
                Console.WriteLine(" Branch: " + student.Branch + ", Name :" + student.FirstName + " " + student.LastName);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqMultiLevelSort
    {
        static void Main(string[] args)
        {
            //Method Syntax
            var MS = Student1.GetAllStudents()
                              .OrderBy(x => x.Branch )     // first lvl sorting
                              .ThenBy(y => y.FirstName )  // second lvl sorting
                              .ToList();

            foreach (var student in MS)
            {
                Console.WriteLine(student.Branch  + " - " + student.FirstName );
            }
            Console.ReadKey();
        }
    }
}

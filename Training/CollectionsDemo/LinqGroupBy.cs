using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqGroupBy
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var GroupByMS = Student1.GetAllStudents().GroupBy(s => s.Branch);
            //Using Query Syntax
            IEnumerable<IGrouping<string, Student1>> GroupByQS = (from std in Student1.GetAllStudents()
                                                                 group std by std.Branch);
            //It will iterate through each groups
            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());
                //Iterate through each student of a group
                foreach (var student in group)
                {
                    Console.WriteLine("  FirstName :" + student.FirstName + ", LastName: " + student.LastName + ", Branch :" + student.Branch);
                }
            }
            Console.Read();
        }
    }
}

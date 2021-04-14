using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Student1
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public static List<Student1> GetAllStudents()
        {
            List<Student1> listStudents = new List<Student1>()
            {
                new Student1{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE"},
                new Student1{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC"},
                new Student1{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC"},
                new Student1{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC"},
                new Student1{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE"},
                new Student1{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE"},
                new Student1{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE"},
                new Student1{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC"},
                new Student1{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC"},
                new Student1{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE"}
            };
            return listStudents;
        }
    }
}

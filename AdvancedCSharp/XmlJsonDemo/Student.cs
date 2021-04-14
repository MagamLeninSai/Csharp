using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonDemo
{
    class Student
    {
        int rollno;
        String name;
        List<String> courses;

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public List<string> Courses { get => courses; set => courses = value; }
    }
}

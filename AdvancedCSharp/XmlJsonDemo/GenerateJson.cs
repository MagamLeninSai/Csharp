using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XmlJsonDemo
{
    class GenerateJson
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.Rollno = 101;
            s1.Name = "Lenin";
            s1.Courses = new List<string> {"Ajax","C#","Java"};
            String jsonResult = JsonConvert.SerializeObject(s1);
            String path = @"c:\\demo\\Student.json";
            using (var t=new StreamWriter(path, true))
            {
                t.WriteLine(jsonResult.ToString());
                t.Close();
            }
                Console.ReadKey();
        }
    }
}

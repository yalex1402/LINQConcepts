using LINQConcepts.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;

namespace LINQConcepts.Core.Data
{
    public class DataContext
    {
        public DataContext()
        {
            Students = new List<Student>
            {
                new Student {Id = 1, Name = "Scott", LastName = "Black", Age = 12, Average = 3.5, SchoolId = 1 },
                new Student {Id = 2, Name = "Billy", LastName = "Graham", Age = 15, Average = 4, SchoolId = 2 },
                new Student {Id = 3, Name = "Lui", LastName = "Gomez", Age = 14, Average = 2.8, SchoolId = 1 },
                new Student {Id = 4, Name = "Laura", LastName = "Whitney", Age = 13, Average = 4.5, SchoolId = 2 },
                new Student {Id = 5, Name = "Phillip", LastName = "Ragazzi", Age = 15, Average = 4.2, SchoolId = 1 }
            };
            Schools = new List<School>
            {
                new School {Id = 1, Name = "Columbia North School", Country = "Columbia"},
                new School{Id = 2,Name = "Bilingual FireStorm School",Country = "New York"}
            };
            CreateXml();
        }

        public void CreateXml()
        {
            var document = new XDocument();
            var studentsXml = new XElement("Students", 
                        from student in Students 
                        select new XElement("Student",
                            new XAttribute("Id", student.Id),
                            new XAttribute("Name", student.Name),
                            new XAttribute("LastName", student.LastName),
                            new XAttribute("Average", student.Average),
                            new XAttribute("Age", student.Age),
                            new XAttribute("SchoolId", student.SchoolId)
                        ) );
            document.Add(studentsXml);
            document.Save("Students.xml");
        }

        public List<Student> Students { get; set; }

        public List<School> Schools { get; set; }
    }
}

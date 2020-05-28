using LINQConcepts.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQConcepts.Core.Data
{
    public class DataContext
    {
        public DataContext()
        {
            Students = new List<Student>
            {
                new Student {Id = 1, Name = "Scott", LastName = "Black", Age = 12, Average = 3.5 },
                new Student {Id = 2, Name = "Billy", LastName = "Graham", Age = 15, Average = 4 },
                new Student {Id = 3, Name = "Lui", LastName = "Gomez", Age = 14, Average = 2.8 },
                new Student {Id = 4, Name = "Laura", LastName = "Whitney", Age = 13, Average = 4.5 },
                new Student {Id = 5, Name = "Phillip", LastName = "Ragazzi", Age = 15, Average = 4.2 }
            };
            Schools = new List<School>
            {
                new School 
                {
                    Id = 1,
                    Name = "Columbia North School",
                    Country = "Columbia",
                    Students = new List<Student>
                    {
                        Students[0],Students[3], Students[4]
                    }
                },
                new School
                {
                    Id = 2,
                    Name = "Bilingual FireStorm School",
                    Country = "New York",
                    Students = new List<Student>
                    {
                        Students[1],Students[2]
                    }
                }
            };
        }

        public List<Student> Students { get; set; }

        public List<School> Schools { get; set; }
    }
}

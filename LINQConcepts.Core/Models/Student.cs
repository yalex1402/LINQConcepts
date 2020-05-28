using System;
using System.Collections.Generic;
using System.Text;

namespace LINQConcepts.Core.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public double Average { get; set; }

        public int SchoolId { get; set; }
    }
}

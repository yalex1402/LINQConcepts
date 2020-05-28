using LINQConcepts.Core.Data;
using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQConcepts.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext();

            var query = dataContext.Students.OrderByDescending(s => s.Average);

            foreach (var student in query.Take(1))
            {
                Console.WriteLine($"{student.LastName} {student.Name}:{student.Average}");
            }
        }

        
    }
}

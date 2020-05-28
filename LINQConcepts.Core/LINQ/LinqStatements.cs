using LINQConcepts.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQConcepts.Core.LINQ
{
    public class LinqStatements
    {
        private DataContext _dataContext;

        public LinqStatements()
        {
            _dataContext = new DataContext();
        }

        public void StudentsByAverage()
        {
            var query = _dataContext.Students.OrderByDescending(s => s.Average);

            var query2 = from student in _dataContext.Students
                         orderby student.Average descending
                         select student;

            foreach (var student in query2)
            {
                Console.WriteLine($"{student.Name} {student.LastName} : {student.Average}");
            }
            LineBreak();
        }

        public void StudentsByAverage(double average)
        {
            var query = _dataContext.Students
                .Where(s => s.Average > average)
                .OrderByDescending(s => s.Average);

            var query2 = from student in _dataContext.Students
                         where student.Average > average
                         orderby student.Average descending
                         select student;

            foreach (var student in query2)
            {
                Console.WriteLine($"{student.Name} {student.LastName} : {student.Average}");
            }
            LineBreak();
        }

        public void SearchStudent(string name)
        {
            var query = _dataContext.Students.FirstOrDefault(s => s.Name.StartsWith(name));

            var query2 = (from student in _dataContext.Students
                         where student.Name.StartsWith(name)
                         select student).FirstOrDefault();

            Console.WriteLine($"FullName: {query.Name} {query.LastName}\nAge: {query.Age}\nAvg: {query.Average}");
            LineBreak();
        }

        private void LineBreak()
        {
            Console.WriteLine("---------------\n");
        }
    }
}

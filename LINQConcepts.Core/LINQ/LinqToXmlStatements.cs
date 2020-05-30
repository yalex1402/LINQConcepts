using LINQConcepts.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;

namespace LINQConcepts.Core.LINQ
{
    public class LinqToXmlStatements
    {
        private DataContext _dataContext;

        public LinqToXmlStatements()
        {
            _dataContext = new DataContext();
        }

        public void GetStudentsBySchool(int schoolId)
        {
            var document = XDocument.Load("Students.xml");

            var query2 = from student in document.Descendants("Student")
                         where student.Attribute("SchoolId")?.Value == schoolId.ToString()
                         select new
                         {
                             Name = student.Attribute("Name").Value + student.Attribute("LastName").Value,
                             Age = student.Attribute("Age").Value,
                             Average = student.Attribute("Average").Value
                         };

            foreach (var item in query2)
            {
                Console.WriteLine($"{item.Name} - Age: {item.Age} - AVG: {item.Average}");
            }
            LineBreak();
        }

        private void LineBreak()
        {
            Console.WriteLine("---------------\n");
        }
    }
}

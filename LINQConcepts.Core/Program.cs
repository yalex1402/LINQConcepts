using LINQConcepts.Core.LINQ;

namespace LINQConcepts.Core
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LinqStatements querys = new LinqStatements();
            // Show all students ordered by average
            querys.StudentsByAverage();
            //Show students who have an average greater than average. This is passed as a parameter
            querys.StudentsByAverage(3.5);
            //First student who has a name like the name passed as parameter
            querys.SearchStudent("P");

        }
    }
}

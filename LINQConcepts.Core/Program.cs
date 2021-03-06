﻿using LINQConcepts.Core.LINQ;

namespace LINQConcepts.Core
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LinqStatements querys = new LinqStatements();
            LinqToXmlStatements querysXml = new LinqToXmlStatements();

            // Show all students ordered by average
            querys.StudentsByAverage();
            //Show students who have an average greater than average. This is passed as a parameter
            querys.StudentsByAverage(3.5);
            //First student who has a name like the name passed as parameter
            querys.SearchStudent("P");
            //Info Students + Schools
            querys.StudentsBySchool();
            //Count of students by school
            querys.CountStudentsBySchool();
            //Get the student who has the best average by school
            querys.BestStudentBySchool();
            //Show the average of notes in the school
            querys.NoteAverageBySchool();

            querysXml.GetStudentsBySchool(1);
            querysXml.GetStudentsBySchool(2);

        }
    }
}

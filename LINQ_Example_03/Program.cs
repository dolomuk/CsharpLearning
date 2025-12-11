using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Example_03
{
    class Student
    {
        public string Name { get; set;}
        public int Grade {get; set;}
        public string Subject {get; set;}
        public int Score {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ_Example_03 - Pratice Grouping and Oredering");

            List<Student> students = new List<Student>()
            {
                new Student() { Name="Alice", Grade=1, Subject="Math", Score=85 },
                new Student() { Name="Bob", Grade=1, Subject="Science", Score=90 },
                new Student() { Name="Charlie", Grade=2, Subject="Music", Score=78 },
                new Student() { Name="David", Grade=3, Subject="Science", Score=88 },
                new Student() { Name="Eve", Grade=1, Subject="Math", Score=92 },
                new Student() { Name="Frank", Grade=2, Subject="Science", Score=75 }
            };

            var groupedStudentsbyGradeQuery =   from student in students
                                                group student by student.Grade into gradeGroup
                                                orderby gradeGroup.Key descending
                                                select gradeGroup;

            foreach(var gradeGroup in groupedStudentsbyGradeQuery)
            {
                Console.WriteLine($"Grade: {gradeGroup.Key}");
                foreach(var student in gradeGroup)
                {
                    Console.WriteLine($"\tName: {student.Name}, Subject: {student.Subject}, Score: {student.Score}");
                }
            }

            // var groupedStudentsbyGradeMethod = students
            //                                     .GroupBy(s => s.Grade)
            //                                     .OrderByDescending(g => g.Key);                                         

            // foreach(var gradeGroup in groupedStudentsbyGradeMethod)
            // {
            //     Console.WriteLine($"Grade: {gradeGroup.Key}");

            //     foreach(var student in gradeGroup)
            //     {
            //         Console.WriteLine($"\tName: {student.Name}, Subject: {student.Subject}, Score: {student.Score}");
            //     }
            // }

            var groupedStudentsbySubjectQuery =   from student in students
                                                  group student by student.Subject into subjectGroup
                                                  select subjectGroup;

            foreach(var subjectGroup in groupedStudentsbySubjectQuery)
            {
                Console.WriteLine($"{subjectGroup.Key} Averages: {subjectGroup.Average(s => s.Score).ToString("F2")}");
            }

            var orderbyStudentsbyScoreQuery = from student in students
                                              orderby student.Score descending
                                              select student;

            foreach(var student in orderbyStudentsbyScoreQuery)
            {
                Console.WriteLine($"Name: {student.Name}, Score: {student.Score}");
            }   

            int highestScore = students.Max(s => s.Score);
            var topStudents = students.Where(s => s.Score == highestScore);

            Console.WriteLine("\nTop Scoring Students:");
            foreach (var student in topStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Subject: {student.Subject}, Score: {student.Score}");
            }                                                       
        }
    }

}

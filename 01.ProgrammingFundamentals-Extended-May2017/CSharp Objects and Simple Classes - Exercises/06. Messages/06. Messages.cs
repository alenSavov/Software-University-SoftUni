using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_AverageGrades
{
    class P04_AverageGrades
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens.First();
                var grade = tokens
                    .Skip(1)
                    .Select(double.Parse)
                    .ToArray();

                var student = new Student()
                {
                    Name = name,
                    Grade = grade

                };
                students.Add(student);
            }

            students = students
                .Where(a => a.AverageGrade >= 5.00)
                .OrderBy(a => a.Name)
                .ThenByDescending(a => a.AverageGrade)
                .ToList();

            foreach (var studen in students)
            {
                Console.WriteLine($"{studen.Name} -> {studen.AverageGrade:F2}");
            }
        }
       
    }

    class Student
    {
        public string Name { get; set; }
        public double[] Grade { get; set; }
        public double AverageGrade => this.Grade.Average();
    }

}


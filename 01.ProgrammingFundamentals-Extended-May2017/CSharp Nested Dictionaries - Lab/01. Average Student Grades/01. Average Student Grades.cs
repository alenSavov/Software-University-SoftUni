using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<Double>();
                }
                studentGrades[name].Add(grade);             

                
            }
            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var value in student.Value)
                {
                    Console.Write($"{value:F2} ");
                }
                Console.WriteLine($"(avg: { student.Value.Average():f2})");
            }

        }
    }
}

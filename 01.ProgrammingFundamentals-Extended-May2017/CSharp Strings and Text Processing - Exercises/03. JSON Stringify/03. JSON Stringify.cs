﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Stringify
{
    public class Students
    {
        public Students(string name, string age, List<string> grades)
        {
            this.Name = name;
            this.Age = age;
            this.Grades = grades;
        }

        public string Name { get; set; }               
        
        public string Age { get; set; }

        public List<string> Grades { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Students> studentsData = new List<Students>();
            

            while (input[0] != "stringify")
            {
                string name = input[0];
                var tokens = input[1].Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string age = tokens[0];
                var grades = new List<string>();
                if (tokens.Length>1)
                {
                    grades = tokens[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                


                var student = new Students(name, age, grades);
                studentsData.Add(student);

                input = Console.ReadLine()
                .Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }


            foreach (var student in studentsData)
            {
               
                Console.WriteLine($"[{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}]}}],");

            }
        }
    }
}
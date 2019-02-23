using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.Linq;

namespace P12_IncreaseSalaries
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var employees = dbContext.Employees
                    .Where(e => e.Department.Name == "Engineering" ||
                        e.Department.Name == "Tool Design" ||
                        e.Department.Name == "Marketing" ||
                        e.Department.Name == "Information Services")                       
                        .OrderBy(e => e.FirstName)
                        .ThenBy(e => e.LastName)
                    .ToArray();

                foreach (var e in employees)
                {
                    e.Salary *= 1.12m;
                    Console.WriteLine($"{e.FirstName} {e.LastName} (${e.Salary:F2})");
                }

                dbContext.SaveChanges();
            }
        }
    }
}

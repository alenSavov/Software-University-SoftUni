using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P05_EmployeesFromResearchAndDevelopment
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var selectedEmployees = dbContext.Employees
                    .Where(e => e.Department.Name == "Research and Development")
                    .OrderBy(e => e.Salary)
                    .ThenByDescending(e => e.FirstName)
                    .Select(e => new { e.FirstName, e.LastName, e.Department, e.Salary })
                    .ToList();

                foreach (var e in selectedEmployees)
                {
                    Console.WriteLine($"{e.FirstName} {e.LastName} from {e.Department.Name} - ${e.Salary:f2}");
                }
            }
        }
    }
}

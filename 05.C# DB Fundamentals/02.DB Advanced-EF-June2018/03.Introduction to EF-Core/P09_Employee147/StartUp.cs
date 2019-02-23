using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P09_Employee147
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContex = new SoftUniContext())
            {
               var employees = dbContex.Employees
                    .Where(e => e.EmployeeId == 147)
                    .Select(e => new
                    {
                        EmployeeName = e.FirstName + " " + e.LastName,
                        JobTitle = e.JobTitle,
                        Projects = e.EmployeesProjects.Select(p => p.Project.Name).OrderBy(p=>p).ToList()
                    })
                    .ToList();

                foreach (var e in employees)
                {
                    Console.WriteLine($"{e.EmployeeName} - {e.JobTitle}");

                    foreach (var p in e.Projects)
                    {
                        Console.WriteLine(p);
                    }
                }

            }
        }
    }
}

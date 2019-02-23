using P02_DatabaseFirst.Data;
using System;
using System.Linq;
using P02_DatabaseFirst.Data.Models;
using System.Globalization;

namespace P07__EmployeesAndProjects
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
               var employees = dbContext.Employees
                    .Where(e => e.EmployeesProjects.Any(s => s.Project.StartDate.Year >= 2001 ||
                        s.Project.StartDate.Year <= 2003))
                    .Select(x => new
                    {
                        EmployeeName = x.FirstName + " " + x.LastName,
                        ManagerName = x.Manager.FirstName + " " + x.Manager.LastName,
                        Projects = x.EmployeesProjects.Select(s => new
                        {
                            ProjectName = s.Project.Name,
                            StartDate = s.Project.StartDate,
                            EndDate = s.Project.EndDate
                        }).ToArray()
                    })
                    .Take(30)
                    .ToArray();

                foreach (var e in employees)
                {
                    Console.WriteLine($"{e.EmployeeName} - Manager: {e.ManagerName}");

                    foreach (var p in e.Projects)
                    {
                        Console.WriteLine($"--{p.ProjectName} - {p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - {p.EndDate?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) ?? "not finished"}");
                    }
                }
            }
        }
    }
}

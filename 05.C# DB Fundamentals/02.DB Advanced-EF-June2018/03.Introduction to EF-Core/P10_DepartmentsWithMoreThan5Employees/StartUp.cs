using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P10_DepartmentsWithMoreThan5Employees
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var departments = dbContext.Departments
                    .Where(d => d.Employees.Count() > 5)
                    .OrderBy(d => d.Employees.Count())
                    .ThenBy(d => d.Name)
                    .Select(d => new
                    {
                        DepartmentName = d.Name,
                        ManagerName = d.Manager.FirstName + " " + d.Manager.LastName,
                        EmployeeInfo = d.Employees.Select(s => new
                        {
                            s.FirstName,
                            s.LastName,
                            s.JobTitle
                        })
                        .OrderBy(s => s.FirstName)
                        .ThenBy(x => x.LastName)
                    })
                    .ToArray();

                foreach (var d in departments)
                {
                    Console.WriteLine($"{d.DepartmentName} - {d.ManagerName}");

                    foreach (var e in d.EmployeeInfo)
                    {
                        Console.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                    }

                    Console.WriteLine("----------");
                }
            }
        }
    }
}

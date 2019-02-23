using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.IO;
using System.Linq;

namespace P03_EmployeesFullInformation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var employees = dbContext.Employees
                     .OrderBy(e => e.EmployeeId)
                     .Select(e => new { e.FirstName, e.LastName, e.MiddleName, e.JobTitle, e.Salary })
                     .ToList();
                
                    foreach (var e in employees)
                    {
                        Console.WriteLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
                    }         
            }
        }
    }
}

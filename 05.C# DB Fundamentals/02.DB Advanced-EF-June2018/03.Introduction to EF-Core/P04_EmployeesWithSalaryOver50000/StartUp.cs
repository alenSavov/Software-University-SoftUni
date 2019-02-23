using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P04_EmployeesWithSalaryOver50000
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var employeeNames = dbContext.Employees
                    .Where(e => e.Salary > 50000)
                    .OrderBy(e => e.FirstName)
                    .Select(e => e.FirstName)
                    .ToList();

                foreach (var name in employeeNames)
                {
                    Console.WriteLine(name);
                }
            } 

        }
    }
}

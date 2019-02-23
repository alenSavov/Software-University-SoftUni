using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P14_DeleteProjectById
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var project2 = dbContext.Projects.Where(e => e.ProjectId == 2).SingleOrDefault();

                var empProjects = dbContext.EmployeesProjects.Where(ep => ep.ProjectId == 2);

                dbContext.EmployeesProjects.RemoveRange(empProjects);
                dbContext.Projects.Remove(project2);

                dbContext.SaveChanges();

                var updatedProjects = dbContext.Projects.Take(10).ToList();

                foreach (var pr in updatedProjects)
                {
                    Console.WriteLine(pr.Name);
                }
            }
        }
    }
}

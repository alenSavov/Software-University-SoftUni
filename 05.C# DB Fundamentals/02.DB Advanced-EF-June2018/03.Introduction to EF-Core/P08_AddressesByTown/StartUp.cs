using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P08_AddressesByTown
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var addresses = dbContext.Addresses
                    .OrderByDescending(a => a.Employees.Count())
                    .ThenBy(t => t.Town.Name)
                    .ThenBy(a => a.AddressText)
                    .Select(a => new
                    {
                        AddressText = a.AddressText,
                        TownName = a.Town.Name,
                        EmployeeCount = a.Employees.Count()
                    })
                    .Take(10)
                    .ToList();

                foreach (var e in addresses)
                {
                    Console.WriteLine($"{e.AddressText}, {e.TownName} - {e.EmployeeCount} employees");
                }


            }
        }
    }
}

using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.IO;
using System.Linq;

namespace P06__AddingANewAddressAndUpdatingEmployee
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var addresses = dbContext.Employees
                    .OrderByDescending(e => e.AddressId)
                    .Select(e => e.Address.AddressText)
                    .Take(10)
                    .ToList();
                
                    foreach (var e in addresses)
                    {
                        Console.WriteLine($"{e}");
                    }
            }
        }
    }
}

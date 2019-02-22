using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employeeData = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            var inputTokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var name = inputTokens[0];
            var salary = decimal.Parse(inputTokens[1]);
            var position = inputTokens[2];
            var department = inputTokens[3];
            Employee employee = new Employee(name, salary, position, department);

            if (inputTokens.Count > 4)
            {
                var ageOrEmail = inputTokens[4];
                if (ageOrEmail.Contains("@"))
                {
                    employee.Email = ageOrEmail;
                }
                else
                {
                    employee.Age = int.Parse(ageOrEmail);
                }
            }

            if (inputTokens.Count > 5)
            {
                employee.Age = int.Parse(inputTokens[5]);
            }
            employeeData.Add(employee);                       

        }
        var result = employeeData
                .GroupBy(e => e.Department)
                .Select(d => new
                {
                    Department = d.Key,
                    AverageSalary = d.Average(e => e.Salary),
                    Employees = d.OrderByDescending(emp => emp.Salary).ToList()
                })
                .OrderByDescending(d => d.AverageSalary)
                .FirstOrDefault();

        if (result != null)
        {
            Console.WriteLine($"Highest Average Salary: {result.Department}");
            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }

    }
}


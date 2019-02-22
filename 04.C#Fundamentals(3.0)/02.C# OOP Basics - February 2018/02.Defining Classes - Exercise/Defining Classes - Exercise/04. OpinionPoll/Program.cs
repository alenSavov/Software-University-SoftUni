using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var peopleData = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);

            Person person = new Person(name, age);
            peopleData.Add(person);
        }
        Console.WriteLine();
        foreach (var person in peopleData.Where(p => p.Age > 30).OrderBy(a => a.Name))
        {
            Console.WriteLine(person);
        }
    }
}


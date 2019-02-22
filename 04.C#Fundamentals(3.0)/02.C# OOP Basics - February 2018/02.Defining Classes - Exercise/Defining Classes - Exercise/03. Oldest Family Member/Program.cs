using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Family family = new Family();

        int counter = 1;
        while (counter <= n)
        {
            var input = Console.ReadLine().Split().ToList();
            var name = input[0];
            var age = int.Parse(input[1]);
            
            Person person = new Person(name, age);
            family.AddMember(person);

            counter++;
        }
        Person oldestMember = family.GetOldestMember();
        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }

          
}


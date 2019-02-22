using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var society = new List<IIdentable>();

        var visitors = Console.ReadLine().Split();
        while (visitors[0] != "End")
        {
            IIdentable currentVisitor;
            if (visitors.Length == 3)
            {
                currentVisitor = new Citizens(visitors[0], int.Parse(visitors[1]), visitors[2]);
                society.Add(currentVisitor);
            }
            if (visitors.Length == 2)
            {
                currentVisitor = new Robots(visitors[0], visitors[1]);
                society.Add(currentVisitor);
            }

            visitors = Console.ReadLine().Split();
        }
        Console.WriteLine();
        var fakeId = Console.ReadLine();
        foreach (var visitor in society.Where(v => v.Id.EndsWith(fakeId)))
        {
            Console.WriteLine(visitor.Id);
        }

    }
}


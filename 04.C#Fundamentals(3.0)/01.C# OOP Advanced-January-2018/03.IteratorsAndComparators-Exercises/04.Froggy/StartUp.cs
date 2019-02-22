using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse);

        Stones<int> stones = new Stones<int>(numbers);
        Console.WriteLine(string.Join(", ", stones));
    }
}


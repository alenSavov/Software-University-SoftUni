using System;

public class Program
{
    static void Main(string[] args)
    {
        var startData = Console.ReadLine();
        var endData = Console.ReadLine();

        DateModifier diff = new DateModifier(startData , endData);
        var result = diff.differenceBetweenDate(startData, endData);

        Console.WriteLine(result);
    }
}


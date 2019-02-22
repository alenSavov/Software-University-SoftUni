using System;


public class StartUp
{
    static void Main(string[] args)
    {
        var driverName = Console.ReadLine();
        ICar ferrari = new Ferrari(driverName);

        Console.WriteLine(ferrari);
    }
}


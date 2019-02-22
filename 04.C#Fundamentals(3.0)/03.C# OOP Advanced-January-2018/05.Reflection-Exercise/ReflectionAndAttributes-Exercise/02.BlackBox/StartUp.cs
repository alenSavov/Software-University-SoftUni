using P02_BlackBoxInteger;
using System;


public class StartUp
{
    static void Main(string[] args)
    {
        Console.WriteLine(new BlackBoxIntegerTest().Run(typeof(BlackBoxInteger)));
       
    }
}


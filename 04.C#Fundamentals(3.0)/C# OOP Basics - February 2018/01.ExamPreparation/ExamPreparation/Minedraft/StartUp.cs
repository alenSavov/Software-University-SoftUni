﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string input;
        var draftManager = new DraftManager();
        while ((input = Console.ReadLine()) != "Shutdown")
        {
            var arguments = input.Split().ToList();
            var command = arguments[0];
            arguments = arguments.Skip(1).ToList();

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(arguments));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(arguments));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(arguments));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(arguments));
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(draftManager.ShutDown());
    }
}


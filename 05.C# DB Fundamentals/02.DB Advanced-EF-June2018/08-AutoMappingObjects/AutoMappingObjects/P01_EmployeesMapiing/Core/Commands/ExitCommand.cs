using EmployeesMapiing.App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EmployeesMapping.App.Core.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            for (int i = 5 - 1; i >= 0; i--)
            {
                Console.WriteLine($"Program will close after {i} seconds!");
                Thread.Sleep(1000);
            }



            Environment.Exit(0);
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapiing.App.Core.Contracts
{
   public interface ICommand
    {
        string Execute(string[] args);
    }
}

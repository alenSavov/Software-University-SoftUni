using EmployeesMapiing.App.Core.Contracts;
using EmployeesMapping.App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapping.App.Core.Commands
{
    public class SetManagerCommand : ICommand
    {
        private readonly IManagerController managerController;

        public SetManagerCommand(IManagerController managerController)
        {
            this.managerController = managerController;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            int managerId = int.Parse(args[1]);

            this.managerController.SetManager(employeeId, managerId);

            return "Command accomplished successfully"; 
        }
    }
}

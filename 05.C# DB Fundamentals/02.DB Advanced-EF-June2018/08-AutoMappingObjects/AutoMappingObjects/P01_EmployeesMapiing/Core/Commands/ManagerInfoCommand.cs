using EmployeesMapiing.App.Core.Contracts;
using EmployeesMapping.App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapping.App.Core.Commands
{
    public class ManagerInfoCommand : ICommand
    {
        private readonly IManagerController managerController;

        public ManagerInfoCommand(IManagerController managerController)
        {
            this.managerController = managerController;
        }

        public string Execute(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int employeeId = int.Parse(args[0]);

            var managerDto = this.managerController.GetManagerInfo(employeeId);

            sb.AppendLine($"{managerDto.FirstNmae} {managerDto.LastName} | Employee: { managerDto.EmployeeDtos}");

            foreach (var employee in managerDto.EmployeeDtos)
            {
                sb.AppendLine($"    -{employee.FirstName} {employee.LastName} - {employee.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}

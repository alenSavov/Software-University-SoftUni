using EmployeesMapping.App.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapping.App.Core.Contracts
{
   public interface IManagerController
    {
        void SetManager(int employeeId, int managerId);

        ManagerDto GetManagerInfo(int empoyeeId);
    }
}

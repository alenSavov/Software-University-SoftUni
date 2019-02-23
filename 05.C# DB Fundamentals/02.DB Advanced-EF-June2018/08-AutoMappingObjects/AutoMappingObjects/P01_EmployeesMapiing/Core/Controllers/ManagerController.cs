using AutoMapper.QueryableExtensions;
using EmployeesMappin.Models;
using EmployeesMapping.App.Core.Contracts;
using EmployeesMapping.App.Core.Dtos;
using EmployeesMapping.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EmployeesMapping.App.Core.Controllers
{
    public class ManagerController : IManagerController
    {
        private readonly EmployeesMappingContext context;

        public ManagerController(EmployeesMappingContext context)
        {
            this.context = context;
        }

        public ManagerDto GetManagerInfo(int employeeId)
        {
            var employee = context.Employees
                                  .Include(x => x.ManagerEmployees)
                                  .Where(x => x.ManagerId == employeeId)
                                  .ProjectTo<ManagerDto>()
                                  .SingleOrDefault();

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            return employee;
        }

        public void SetManager(int employeeId, int managerId)
        {
            var employee = context.Employees.Find(employeeId);
            var manager = context.Employees.Find(managerId);

            if (employee == null || manager == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            employee.Manager = manager;

            context.SaveChanges();
        }
    }
}

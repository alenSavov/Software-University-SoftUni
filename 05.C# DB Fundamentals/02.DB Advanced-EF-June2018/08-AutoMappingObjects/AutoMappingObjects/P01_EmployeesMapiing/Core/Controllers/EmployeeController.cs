using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmployeesMapiing.App.Core.Contracts;
using EmployeesMapiing.App.Core.Dtos;
using EmployeesMappin.Models;
using EmployeesMapping.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeesMapiing.App.Core.Controllers
{
    public class EmployeeController : IEmployeeController
    {
        private readonly EmployeesMappingContext context;
        private readonly IMapper mapper;

        public EmployeeController(EmployeesMappingContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddEmployee(EmployeeDto employeeDto)
        {
            var employee = mapper.Map<Employees>(employeeDto);
            this.context.Employees.Add(employee);

            this.context.SaveChanges();
        }

        public void SetAddress(int employeeId, string address)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            employee.Address = address;

            context.SaveChanges();
        }

        public void SetBirthday(int employeeId, DateTime date)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            employee.Birthday = date;

            context.SaveChanges();
        }

        public EmployeeDto GetEmployeeInfo(int employeeId)
        {
            var employee = context.Employees
                                .Find(employeeId);

            var employeeDto = mapper.Map<EmployeeDto>(employee);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            return employeeDto;
        }

        public EmployeePersonalInfoDto GetEmployeePersonalInfo(int employeeId)
        {
            var employee = context.Employees
                                 .Find(employeeId);

            var employeeDto = mapper.Map<EmployeePersonalInfoDto>(employee);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            return employeeDto;
        }
    }
}

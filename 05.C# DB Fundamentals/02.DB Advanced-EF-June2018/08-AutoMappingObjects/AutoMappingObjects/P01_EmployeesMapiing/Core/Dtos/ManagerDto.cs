using EmployeesMapiing.App.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapping.App.Core.Dtos
{
    public class ManagerDto
    {
        public ManagerDto()
        {
            this.EmployeeDtos = new HashSet<EmployeeDto>();
        }

        public string FirstNmae { get; set; }

        public string LastName { get; set; }

        public int EmployeesCount => EmployeeDtos.Count; 

        public ICollection<EmployeeDto> EmployeeDtos { get; set; }
    }
}

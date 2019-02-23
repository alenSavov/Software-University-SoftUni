using System;
using System.Collections.Generic;

namespace EmployeesMappin.Models
{
    public class Employees
    {
        public Employees()
        {
            this.ManagerEmployees = new HashSet<Employees>();
        }

        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public int? ManagerId { get; set; }
        public Employees Manager { get; set; }

        public ICollection<Employees> ManagerEmployees { get; set; }

    }
}

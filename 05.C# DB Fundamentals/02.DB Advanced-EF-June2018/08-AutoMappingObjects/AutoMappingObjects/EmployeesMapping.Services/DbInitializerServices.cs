using EmployeesMapping.Data;
using EmployeesMapping.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeesMapping.Services
{
    public class DbInitializerService : IDbInitializerService
    {

        private readonly EmployeesMappingContext context;

        public DbInitializerService(EmployeesMappingContext context)
        {
            this.context = context;
        }

        public void InializeDatabase()
        {
            this.context.Database.Migrate();
        }
    }
}

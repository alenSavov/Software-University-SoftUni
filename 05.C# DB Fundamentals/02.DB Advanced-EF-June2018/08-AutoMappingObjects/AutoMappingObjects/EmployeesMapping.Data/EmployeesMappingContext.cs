using EmployeesMappin.Models;
using EmployeesMapping.Data.EntityConfiguration;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapping.Data
{
    public class EmployeesMappingContext : DbContext
    {
        public EmployeesMappingContext(DbContextOptions options) 
            : base(options)
        {
        }

        public EmployeesMappingContext()
        {
        }

        public DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}

using EmployeesMappin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapping.Data.EntityConfiguration
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.HasKey(x => x.EmployeeId);

            builder.Property(x => x.FirstName)
                .IsRequired(true);

            builder.Property(x => x.LastName)
               .IsRequired(true);

            builder.Property(x => x.Salary)
               .IsRequired(true);

            builder.HasOne(x => x.Manager)
                .WithMany(x => x.ManagerEmployees)
                .HasForeignKey(x => x.ManagerId);
        }


    }
}

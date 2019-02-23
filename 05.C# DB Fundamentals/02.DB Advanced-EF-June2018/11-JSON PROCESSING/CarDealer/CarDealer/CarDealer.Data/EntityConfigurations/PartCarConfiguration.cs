using CarDealer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Data.EntityConfigurations
{
    public class PartCarConfiguration : IEntityTypeConfiguration<PartCar>
    {
        public void Configure(EntityTypeBuilder<PartCar> builder)
        {
            builder.HasKey(x => new { x.PartId, x.CarId });

            builder.HasOne(x => x.Part)
                   .WithMany(x => x.Cars)
                   .HasForeignKey(x => x.PartId);

            builder.HasOne(x => x.Car)
               .WithMany(x => x.Parts)
               .HasForeignKey(x => x.CarId);
        }
    }
}

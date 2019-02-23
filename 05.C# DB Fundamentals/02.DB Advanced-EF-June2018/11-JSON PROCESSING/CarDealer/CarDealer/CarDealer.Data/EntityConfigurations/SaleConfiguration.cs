using CarDealer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealer.Data.EntityConfigurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.SaleId);

            builder.HasOne(x => x.Customer)
                   .WithMany(x => x.Sales)
                   .HasForeignKey(x => x.CustomerId);

            builder.Property(x => x.Discount)
                  .HasDefaultValue(0.00);
        }
    }
}

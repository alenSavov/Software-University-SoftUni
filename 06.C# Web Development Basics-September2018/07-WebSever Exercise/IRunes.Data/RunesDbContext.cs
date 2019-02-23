namespace IRunes.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;

    public class RunesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}

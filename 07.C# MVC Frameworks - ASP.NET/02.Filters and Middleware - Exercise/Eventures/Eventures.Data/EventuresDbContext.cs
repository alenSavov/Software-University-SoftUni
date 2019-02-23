using Eventures.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Eventures.Data
{
    public class EventuresDbContext : IdentityDbContext<User>
    {
        public EventuresDbContext(DbContextOptions<EventuresDbContext> options) 
            : base(options)
        {
        }

        public EventuresDbContext()
            : base()
        {
            var dbContextOptions = new DbContextOptionsBuilder<EventuresDbContext>();
            dbContextOptions.UseSqlServer("Server=DESKTOP-U67U5UI\\SQLEXPRESS;Database=Eventures;Trusted_Connection=True;MultipleActiveResultSets=true");

        }

        public DbSet<Event> Eventd { get; set; }

        public DbSet<CustomLog> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Event>()
                .Property(p => p.PricePerTicket)
                .HasColumnType("decimal(18,2)");

            builder.Entity<UserEvents>()
                   .HasKey(x => new { x.EventId, x.UserId });

            base.OnModelCreating(builder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Mish_Mash.Models;

namespace Mish_Mash.Data
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Channel> Channels { get; set; }

        DbSet<Tag> Tags { get; set; }

        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-U67U5UI\SQLEXPRESS;Database=MishMash;Integrated Security=True;");
        }
    }
}

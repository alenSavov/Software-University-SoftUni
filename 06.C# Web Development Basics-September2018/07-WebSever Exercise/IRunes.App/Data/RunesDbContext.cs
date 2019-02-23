namespace IRunes.Data
{
    using IRunes.App.Models;
    using Microsoft.EntityFrameworkCore;
    using System;

    public class RunesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<TrackAlbum> TrackAlbums { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(Configuration.ConnectionString)
                .UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TrackAlbum>()
                .HasKey(ta => new { ta.TrackId, ta.AlbumId });
        }
    }
}

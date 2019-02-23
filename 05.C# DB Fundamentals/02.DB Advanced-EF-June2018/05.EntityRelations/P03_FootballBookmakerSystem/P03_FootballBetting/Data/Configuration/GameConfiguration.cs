using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(x => x.GameId);

            builder.HasOne(x => x.HomeTeam)
                  .WithMany(x => x.HomeGames)
                  .HasForeignKey(x => x.HomeTeamId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.AwayTeam)
                  .WithMany(x => x.AwayGames)
                  .HasForeignKey(x => x.AwayTeamId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

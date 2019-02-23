using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.Configuration
{
    public class PlayerStatisticsConfiguration : IEntityTypeConfiguration<PlayerStatistic>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistic> builder)
        {

            builder.HasKey(x => x.PlayerId);
            builder.HasKey(x => x.GameId);

            builder.HasOne(x => x.Game)
                       .WithMany(x => x.PlayerStatistics)
                       .HasForeignKey(x => x.GameId);

            builder.HasOne(x => x.Player)
                       .WithMany(x => x.PlayerStatistics)
                       .HasForeignKey(x => x.PlayerId);

        }
    }
}
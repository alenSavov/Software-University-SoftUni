using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TeamBuilder.Model;

namespace TeamBuilder.Data.EntityConfiguration
{
    public class TeamEventConfig : IEntityTypeConfiguration<EventTeam>
    {
        public void Configure(EntityTypeBuilder<EventTeam> builder)
        {
            builder.HasKey(x => new { x.TeamId, x.EventId });

            builder
                .HasOne(x => x.Team)
                .WithMany(x => x.Events)
                .HasForeignKey(x => x.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Event)
                .WithMany(x => x.ParticipatingEventTeams)
                .HasForeignKey(x => x.EventId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

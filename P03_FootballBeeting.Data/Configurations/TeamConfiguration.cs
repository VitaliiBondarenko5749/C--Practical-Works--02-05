using FootballBeeting.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P03_FootballBeeting.Data.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.TeamId);

            builder.HasOne(t => t.Town)
                .WithMany(town => town.Teams)
                .HasForeignKey(t => t.TownId);

            builder.HasOne(t => t.PrimaryKitColor)
                .WithMany(c => c.PrimaryColorTeams)
                .HasForeignKey(t => t.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.SecondaryKitColor)
                .WithMany(c => c.SecondaryColorTeams)
                .HasForeignKey(t => t.SecondaryKitColorId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
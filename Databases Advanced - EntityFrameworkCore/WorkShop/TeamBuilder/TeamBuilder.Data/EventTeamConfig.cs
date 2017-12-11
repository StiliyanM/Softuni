using Microsoft.EntityFrameworkCore;
using TeamBuilder.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TeamBuilder.Data
{
    public class EventTeamConfig : IEntityTypeConfiguration<EventTeam>
    {
        public void Configure(EntityTypeBuilder<EventTeam> builder)
        {
            builder.HasKey(e => new { e.EventId, e.TeamId });

            builder.ToTable("EventTeams");

            builder.HasOne(e => e.Event)
                .WithMany(ev => ev.ParticipatingEventTeams)
                .HasForeignKey(e => e.EventId);

            builder.HasOne(e => e.Team)
                .WithMany(t => t.EventTeams)
                .HasForeignKey(e => e.TeamId);
        }
    }
}

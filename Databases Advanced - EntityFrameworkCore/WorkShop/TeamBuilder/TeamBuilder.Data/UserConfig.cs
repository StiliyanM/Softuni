using Microsoft.EntityFrameworkCore;
using TeamBuilder.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TeamBuilder.Data
{
    class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(e => e.CreatedEvents)
                .WithOne(ev => ev.Creator)
                .HasForeignKey(ev => ev.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.ReceivedInvitations)
                .WithOne(i => i.InvitedUser)
                .HasForeignKey(i => i.InvitedUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.UserName)
                .IsRequired();

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(30);

            builder.HasIndex(e => e.UserName)
                .IsUnique();

            builder.Property(u => u.FirstName)
                .HasMaxLength(25);

            builder.Property(u => u.LastName)
                .HasMaxLength(25);
        }
    }
}

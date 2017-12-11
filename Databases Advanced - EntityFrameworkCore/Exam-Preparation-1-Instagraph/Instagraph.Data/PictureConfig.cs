using Instagraph.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Instagraph.Data
{
    class PictureConfig : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.Property(e => e.Path)
                .IsRequired();

            builder.HasMany(e => e.Users)
                .WithOne(u => u.ProfilePicture)
                .HasForeignKey(u => u.ProfilePictureId);

            builder.HasMany(e => e.Posts)
                .WithOne(p => p.Picture)
                .HasForeignKey(p => p.PictureId);
        }
    }
}

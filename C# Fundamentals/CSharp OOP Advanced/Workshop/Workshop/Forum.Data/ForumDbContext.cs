using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data
{
    public class ForumDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Reply> Replies { get; set; }

        public DbSet<User> Users { get; set; }

        public ForumDbContext(DbContextOptions options) : base(options)
        {
        }

        public ForumDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionConfig.ConnectionString);
            }

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Post>(entity =>
            {
                entity.HasOne(e => e.Category)
                .WithMany(c => c.Posts)
                .HasForeignKey(e => e.CategoryId);

                entity.HasOne(e => e.Author)
                .WithMany(u => u.Posts)
                .HasForeignKey(e => e.AuthorId);

                entity.HasMany(e => e.Replies)
                .WithOne(r => r.Post)
                .HasForeignKey(r => r.PostId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Reply>(entity =>
            {
                entity.HasOne(e => e.Author)
                .WithMany(u => u.Replies)
                .HasForeignKey(e => e.AuthorId);
            });
        }
    }
}

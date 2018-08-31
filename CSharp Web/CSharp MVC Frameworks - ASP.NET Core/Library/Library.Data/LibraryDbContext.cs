namespace Library.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class LibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Borrower> Borrowers { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BooksBorrower> BooksBorrowed { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<MoviesBorrower> MoviesBorrowed { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-HO1UOB5\SQLEXPRESS;Database=Library;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            builder.Entity<Author>()
                .HasIndex(a => a.Name)
                .IsUnique();

            builder.Entity<Borrower>()
                .HasIndex(b => b.Name)
                .IsUnique();

            builder.Entity<Book>(entity =>
            {
                entity.HasOne(e => e.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(e => e.AuthorId);
            });

            builder.Entity<BooksBorrower>(entity =>
            {
                entity.HasKey(e => new { e.BorrowerId, e.BookId });

                entity.HasOne(e => e.Book)
                .WithMany(b => b.Borrowers)
                .HasForeignKey(e => e.BookId);

                entity.HasOne(e => e.Borrower)
                .WithMany(b => b.Books)
                .HasForeignKey(e => e.BorrowerId);
            });

            builder.Entity<Director>()
                .HasIndex(d => d.Name)
                .IsUnique();

            builder.Entity<MoviesBorrower>(entity =>
            {
                entity.HasKey(e => new { e.BorrowerId, e.MovieId });

                entity.HasOne(e => e.Movie)
                .WithMany(m => m.Borrowers)
                .HasForeignKey(e => e.MovieId);

                entity.HasOne(e => e.Borrower)
                .WithMany(b => b.Movies)
                .HasForeignKey(e => e.BorrowerId);
            });



        }
    }
}

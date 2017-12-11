namespace P03_FootballBetting.Data
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data.Models;

    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
           : base()
        { }

        public FootballBettingContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Town>(entity =>
            {
                entity.HasOne(t => t.Country)
                      .WithMany(c => c.Towns)
                      .HasForeignKey(t => t.CountryId);
            });

            builder.Entity<Bet>(entity =>
            {
                entity.Property(e => e.Prediction)
                      .IsRequired(true);

                entity.HasOne(b => b.User)
                      .WithMany(u => u.Bets)
                      .HasForeignKey(b => b.UserId);

                entity.HasOne(b => b.Game)
                      .WithMany(g => g.Bets)
                      .HasForeignKey(b => b.GameId);
            });

            builder.Entity<Player>(entity =>
            {
                entity.HasOne(p => p.Position)
                      .WithMany(po => po.Players)
                      .HasForeignKey(p => p.PositionId);
            });

            builder.Entity<Team>(entity =>
            {
                entity.HasOne(t => t.PrimaryKitColor)
                      .WithMany(c => c.PrimaryKitTeams)
                      .HasForeignKey(t => t.PrimaryKitColorId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(t => t.SecondaryKitColor)
                      .WithMany(c => c.SecondaryKitTeams)
                      .HasForeignKey(t => t.SecondaryKitColorId)
                      .OnDelete(DeleteBehavior.Restrict); ;

                entity.HasOne(t => t.Town)
                      .WithMany(c => c.Teams)
                      .HasForeignKey(t => t.TownId);

                entity.HasMany(t => t.HomeGames)
                     .WithOne(g => g.HomeTeam)
                     .HasForeignKey(g => g.HomeTeamId)
                     .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(t => t.AwayGames)
                     .WithOne(g => g.AwayTeam)
                     .HasForeignKey(g => g.AwayTeamId)
                     .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(t => t.Players)
                     .WithOne(p => p.Team)
                     .HasForeignKey(p => p.TeamId);
            });

            builder.Entity<PlayerStatistic>(entity =>
            {
                entity.HasKey(ps => new { ps.GameId, ps.PlayerId });

                entity.HasOne(sp => sp.Game)
                      .WithMany(c => c.PlayerStatistics)
                      .HasForeignKey(sp => sp.GameId);

                entity.HasOne(sp => sp.Player)
                      .WithMany(p => p.PlayerStatistics)
                      .HasForeignKey(sp => sp.PlayerId);
            });
        }
    }
}
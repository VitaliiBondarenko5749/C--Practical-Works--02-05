using FootballBeeting.Data.Models;
using Microsoft.EntityFrameworkCore;
using P03_FootballBeeting.Data.Configurations;

namespace P03_FootballBeeting.Data
{
    public class FootballBeetingContext : DbContext
    {
        public DbSet<Bet> Bets => Set<Bet>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Game> Games => Set<Game>();
        public DbSet<PlayerStatistic> PlayerStatistics => Set<PlayerStatistic>();
        public DbSet<Player> Players => Set<Player>();
        public DbSet<Team> Teams => Set<Team>();
        public DbSet<Color> Colors => Set<Color>();
        public DbSet<Position> Positions => Set<Position>();
        public DbSet<Town> Towns => Set<Town>();
        public DbSet<Country> Countries => Set<Country>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=VITALII-PC;Initial Catalog=FootballBeetingDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new ColorConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TownConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerStatisticConfiguration());
            modelBuilder.ApplyConfiguration(new BetConfiguration());
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class SportContext : DbContext
    {
        public SportContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var team = new Team
            {
                Id = 1,
                Name = "Спартак"
            };

            var player = new Player
            {
                Id = 1,
                FullName = "Роналдо",
                Number = 7,
                TeamId = team.Id
            };

            modelBuilder.Entity<Team>().HasData(team);
            modelBuilder.Entity<Player>().HasData(player);

            base.OnModelCreating(modelBuilder);
        }
    }
}

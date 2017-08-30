using System.Data.Entity;
using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.DataAccess
{
    public class StatsDbContext:DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<GameEvent> GameEvents { get; set; }
    }
}
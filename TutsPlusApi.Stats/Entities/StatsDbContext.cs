using System.Data.Entity;

namespace TutsPlusApi.Stats.Entities
{
    public class StatsDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
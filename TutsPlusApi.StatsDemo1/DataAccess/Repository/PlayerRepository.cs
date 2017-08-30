using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.DataAccess.Repository
{
    public class PlayerRepository:Repository<Player>
    {
        public PlayerRepository(StatsDbContext context) : base(context)
        {
        }
    }
}
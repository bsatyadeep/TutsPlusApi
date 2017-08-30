using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.DataAccess.Repository
{
    public class GameRepository:Repository<Game>
    {
        public GameRepository(StatsDbContext context) : base(context)
        {
        }
    }
}
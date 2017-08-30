using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.DataAccess.Repository
{
    public class TeamRepository:Repository<Team>
    {
        public TeamRepository(StatsDbContext context) : base(context)
        {
        }
    }
}
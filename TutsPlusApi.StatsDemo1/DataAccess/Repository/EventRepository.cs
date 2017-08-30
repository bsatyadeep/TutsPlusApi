using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.DataAccess.Repository
{
    public class EventRepository:Repository<GameEvent>
    {
        public EventRepository(StatsDbContext context) : base(context)
        {
        }
    }
}
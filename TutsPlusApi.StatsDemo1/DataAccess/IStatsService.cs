using TutsPlusApi.StatsDemo1.DataAccess.Entities;
using TutsPlusApi.StatsDemo1.DataAccess.Repository;

namespace TutsPlusApi.StatsDemo1.DataAccess
{
    public interface IStatsService
    {
        Repository<Game> Games { get; }
        Repository<Team> Teams { get; }
        Repository<Player> Players { get; }
        Repository<GameEvent> Events { get; }
    }
}
using TutsPlusApi.StatsDemo1.DataAccess.Entities;
using TutsPlusApi.StatsDemo1.DataAccess.Repository;

namespace TutsPlusApi.StatsDemo1.DataAccess
{
    public class StatsService:IStatsService
    {
        private Repository<Game> _gameRepository;
        private Repository<Team> _teamRepository;
        private Repository<Player> _playerRepository;
        private Repository<GameEvent> _eventRepository;
          
        public Repository<Game> Games => _gameRepository ?? (_gameRepository = new GameRepository(new StatsDbContext()));
        public Repository<Team> Teams => _teamRepository ?? (_teamRepository = new TeamRepository(new StatsDbContext()));
        public Repository<Player> Players=> _playerRepository??(_playerRepository = new PlayerRepository(new StatsDbContext()));
        public Repository<GameEvent> Events =>_eventRepository??(_eventRepository = new EventRepository(new StatsDbContext()));
    }
}
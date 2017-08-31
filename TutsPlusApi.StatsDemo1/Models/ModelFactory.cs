using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.Models
{
    public class ModelFactory:IModelFactory
    {
        public PlayerModel Create(Player player)
        {
            return new PlayerModel
            {
                PlayerId = player.Id,
                FirstName = player.FirstName,
                LastName = player.LastName,
                TeamId = player.Team.Id,
                TeamName = player.Team.Name
            };
        }
    }
}
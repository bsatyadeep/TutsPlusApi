using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.Models
{
    public interface IModelFactory
    {
        PlayerModel Create(Player player);
    }
}
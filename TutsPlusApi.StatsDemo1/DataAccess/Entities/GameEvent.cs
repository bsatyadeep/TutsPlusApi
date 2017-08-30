namespace TutsPlusApi.StatsDemo1.DataAccess.Entities
{
    public class GameEvent:EntityBase
    {
        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }
        public int Point { get; set; }
    }
}
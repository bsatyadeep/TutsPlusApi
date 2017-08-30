using System;

namespace TutsPlusApi.StatsDemo1.DataAccess.Entities
{
    public class Game:EntityBase
    {
        public virtual Team HomeTeam { get; set; }
        public virtual Team AnyTeam { get; set; }
        public DateTime StartTime { get; set; }
    }
}
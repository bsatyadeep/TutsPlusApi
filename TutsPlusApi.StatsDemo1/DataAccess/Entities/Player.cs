using System;

namespace TutsPlusApi.StatsDemo1.DataAccess.Entities
{
    public class Player:EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Team Team { get; set; }
    }
}
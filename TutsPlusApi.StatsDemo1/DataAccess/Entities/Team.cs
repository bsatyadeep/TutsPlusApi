using System;
using System.Collections.Generic;

namespace TutsPlusApi.StatsDemo1.DataAccess.Entities
{
    public class Team:EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<Player> Players { get; set; }  
    }
}
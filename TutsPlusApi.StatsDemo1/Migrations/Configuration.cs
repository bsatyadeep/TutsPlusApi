using System;
using System.Collections.Generic;
using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TutsPlusApi.StatsDemo1.DataAccess.StatsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccess.StatsDbContext context)
        {
            var p1 = new Player {FirstName = "John", LastName = "Doe", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now};
            var p2 = new Player {FirstName = "Frank", LastName = "Doe", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now};
            var p3 = new Player {FirstName = "Robbie", LastName = "Johanson", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now};
            var p4 = new Player {FirstName = "Billy", LastName = "Bob", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now};

            var t1 = new Team {Name = "Rhinos",CreatedOn = DateTime.Now,UpdatedOn = DateTime.Now,Players = new List<Player> {p1,p2} };
            var t2 = new Team {Name = "Eagles",CreatedOn = DateTime.Now,UpdatedOn = DateTime.Now,Players = new List<Player> {p3,p4} };

            p1.Team = t1;
            p2.Team = t1;
            p3.Team = t2;
            p4.Team = t2;

            var g1 = new Game { AnyTeam = t1,HomeTeam = t2,CreatedOn = DateTime.Now,UpdatedOn = DateTime.Now,StartTime = DateTime.Now};

            context.Players.Add(p1);
            context.Players.Add(p2);
            context.Players.Add(p3);
            context.Players.Add(p4);

            context.Teams.Add(t1);
            context.Teams.Add(t2);

            context.Games.Add(g1);
        }
    }
}
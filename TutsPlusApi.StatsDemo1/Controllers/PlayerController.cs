using System.Linq;
using System.Web.Http;
using TutsPlusApi.StatsDemo1.DataAccess;
using TutsPlusApi.StatsDemo1.Models;

namespace TutsPlusApi.StatsDemo1.Controllers
{
    public class PlayerController : ApiController
    {
        private readonly IStatsService _service;
        private readonly IModelFactory _modelFactory;
        //public PlayerController(IStatsService service)
        //{
        //    _service = service;
        //}
        public PlayerController()
        {
            _service = new StatsService();
            _modelFactory = new ModelFactory();
        }
        public IHttpActionResult Get()
        {
            //var players = _service.Players.get().Select(p=>new PlayerModel
            //{
            //    PlayerId = p.Id,
            //    FirstName = p.FirstName,
            //    LastName=p.LastName,
            //    TeamId = p.Team.Id,
            //    TeamName = p.Team.Name
            //}).ToList();
            //return Ok(players);

            var players = _service.Players.get();
            var models = players.Select(_modelFactory.Create);
            return Ok(models);
        }

        public IHttpActionResult Get(int id)
        {
            var player = _service.Players.Get(id);
            var model = _modelFactory.Create(player);
            return Ok(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TutsPlusApi.Demo3.Controllers
{
    public class CatController : ApiController
    {
        private static List<string> _listCats;

        public CatController()
        {
            if (_listCats == null)
            {
                _listCats = new List<string>
                {
                    "John",
                    "Paul",
                    "Geroge"
                };
            }
        }

        public List<string> Get()
        {
            return _listCats;
        }

        public string Get(int id)
        {
            return _listCats.Count > id ? _listCats[id] : string.Empty;
        }
    }
}

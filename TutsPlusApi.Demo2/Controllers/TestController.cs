using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TutsPlusApi.Demo2.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public int IWantANumber()
        {
            return 1000;
        }
        [HttpGet]
        public int IWantANumber(int id)
        {
            return id;
        }
    }
}

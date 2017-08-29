using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TutsPlusApi.Demo2.Controllers
{
    public class Sample
    {
        public int Id { get; set; }
        public string Description { get; set; } 
    }
    public class TestController : ApiController
    {
        //[HttpGet]
        //public int IWantANumber()
        //{
        //    return 1000;
        //}
        //[HttpGet]
        //public int IWantANumber(int id)
        //{
        //    return id;
        //}

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.NotAcceptable,50);
        }

        public IHttpActionResult Get(int id)
        {
            var sample = new Sample {Id = 1, Description = "John"};
            return Ok(sample);
        }

        public IHttpActionResult Post(int id)
        {
            return Ok(id);
        }
        public IHttpActionResult Post([FromBody]Sample sample)
        {
            return Ok(sample);
        }
    }
}

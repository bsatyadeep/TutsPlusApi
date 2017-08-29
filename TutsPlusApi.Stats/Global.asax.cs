using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace TutsPlusApi.Stats
{
    //D:\Download\Torrents\Books\Web Api\TutsPlus - ASP.NET At Your Service- Web API
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}

 using System;
using System.Collections.Generic;
 using System.Diagnostics;
 using System.Linq;
 using System.Net.Http.Formatting;
 using System.Web.Http;
 using Newtonsoft.Json;

namespace TutsPlusApi.Demo2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //foreach (var formatter in config.Formatters)
            //{
            //    Debug.WriteLine(formatter.GetType());
            //    foreach (var mediaTypeHeaderValue in formatter.SupportedMediaTypes)
            //    {
            //        Debug.WriteLine("\t"+mediaTypeHeaderValue.MediaType);
            //    }
            //}
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var json = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            json.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
        }
    }
}

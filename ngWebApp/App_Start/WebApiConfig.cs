using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ngWebApp
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
              new { id = RouteParameter.Optional });
        }
    }
}
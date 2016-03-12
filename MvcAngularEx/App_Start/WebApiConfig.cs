using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace MvcAngularEx
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {      

            //config.Formatters.Add(new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter));
            
 //           config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //config.Formatters.Add(new CamelCasePropertyNamesContractResolver(config.Formatters.JsonFormatter));
            
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

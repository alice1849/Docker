
using System.Web.Http;
namespace Web.Api1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            config.EnableCors();

            // config.Routes.MapHttpRoute(
            //     name: "DefaultApi",
            //     routeTemplate: "api/{controller}/{id}",
            //     defaults: new { id = RouteParameter.Optional }
            // );
        }
    }
}

using System.Web.Mvc;
using System.Web.Routing;

namespace BelfastWF_bkend
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "LogIn",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "LogIn", id = UrlParameter.Optional }
            );
        }
    }
}

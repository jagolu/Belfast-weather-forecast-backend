using System;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using Microsoft.Owin.Security.OAuth;
using BelfastWF_bkend.Providers;

[assembly: OwinStartup(typeof(BelfastWF_bkend.Startup))]
namespace BelfastWF_bkend
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            ConfigureOAuth(app);
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/login"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}
using System;
using System.Threading.Tasks;
using System.Web.Http;
using Estudos.WF.Solid.Infra.IoC;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;

[assembly: OwinStartup(typeof(Estudos.WF.Solid.Service.WebApi.Startup))]

namespace Estudos.WF.Solid.Service.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            BootstrapWeb.Register(container);

            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            HubConfiguration hubConfig = new HubConfiguration
            {
                EnableDetailedErrors = true,
                EnableJSONP = true
            };

            app.UseWebApi(config);
            app.MapSignalR();
            app.RunSignalR(hubConfig);

            SwaggerConfig.Register(config);
        }
    }
}

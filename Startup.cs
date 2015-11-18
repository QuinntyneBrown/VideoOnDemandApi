using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Unity.WebApi;

[assembly: OwinStartup(typeof(VideoOnDemandApi.Startup))]

namespace VideoOnDemandApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(VideoOnDemandApi.Server.UnityConfiguration.GetContainer());

            GlobalConfiguration.Configure(config => VideoOnDemandApi.Server.ApiConfiguration.Install(config, app));
        }
    }
}

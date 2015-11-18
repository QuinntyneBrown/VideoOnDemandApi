using Common.Caching;
using Common.Caching.Contracts;
using Microsoft.Practices.Unity;
using VideoOnDemandApi.Server.Data;
using VideoOnDemandApi.Server.Data.Contracts;
using VideoOnDemandApi.Server.Services;
using VideoOnDemandApi.Server.Services.Contracts;


namespace VideoOnDemandApi.Server
{
    public class UnityConfiguration
    {
        public static IUnityContainer GetContainer(bool useMock = false)
        {
            var container = new UnityContainer();
            container.RegisterType<IVideoOnDemandUow, VideoOnDemandUow>();
            container.RegisterType<IVideoOnDemandContext, VideoOnDemandContext>();
            container.RegisterType<ISessionService, SessionService>();
            container.RegisterType<IIdentityService, IdentityService>();
            container.RegisterType<IEncryptionService, EncryptionService>();
            container.RegisterType<ICacheProvider, CacheProvider>();
            container.RegisterType<ISecurityService, SecurityService>();
            return container;
        }
    }
}

using System;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using VideoOnDemandApi.Server.Config;
using VideoOnDemandApi.Server.Services.Contracts;

namespace VideoOnDemandApi.Server.Auth
{
    public class OAuthOptions : OAuthAuthorizationServerOptions
    {
        public OAuthOptions(VideoOnDemandApi.Server.Services.Contracts.IIdentityService identityService)
        {
            var config = AppConfiguration.Config;

            TokenEndpointPath = new PathString(config.TokenPath);
            AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(config.ExpirationMinutes);
            AccessTokenFormat = new JwtWriterFormat(this);
            Provider = new OAuthProvider(identityService);
            AllowInsecureHttp = true;
        }

    }
}

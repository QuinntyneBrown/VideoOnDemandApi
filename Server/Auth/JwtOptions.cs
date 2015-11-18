using Microsoft.Owin.Security.Jwt;
using VideoOnDemandApi.Server.Config;

namespace VideoOnDemandApi.Server.Auth
{
    public class JwtOptions : JwtBearerAuthenticationOptions
    {
        public JwtOptions()
        {
            var config = AppConfiguration.Config;

            AllowedAudiences = new[] { config.JwtAudience };
            IssuerSecurityTokenProviders = new[] 
            {
                new SymmetricKeyIssuerSecurityTokenProvider(config.JwtIssuer, config.JwtKey)
            };
        }
    }
}
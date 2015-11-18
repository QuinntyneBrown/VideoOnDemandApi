namespace VideoOnDemandApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VideoOnDemandApi.Server.Data.VideoOnDemandContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(VideoOnDemandApi.Server.Data.VideoOnDemandContext context)
        {
            UserConfiguration.Seed(context);
            VideoConfiguration.Seed(context);
        }
    }
}

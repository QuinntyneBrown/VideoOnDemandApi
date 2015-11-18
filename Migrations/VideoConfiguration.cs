using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using VideoOnDemandApi.Server.Data;
using VideoOnDemandApi.Server.Models;

namespace VideoOnDemandApi.Migrations
{
    public class VideoConfiguration
    {
        public static void Seed(VideoOnDemandContext context)
        {
            var video = new Video()
            {
                Id = 1,
                Title = "Angular Hackathon",
                Description = "Angular Hackathon",
                YouTubeId = "VdxTkx4qnKg",
                Type = VideoProviderType.YouTube
            };

            context.Videos.AddOrUpdate(video);

            video = new Video()
            {
                Id = 2,
                Title = "Angular 2 Better Concepts Less Code",
                Description = "Angular 2 Better Concepts Less Code",
                YouTubeId = "4YmnbGoh49U",
                Type = VideoProviderType.YouTube
            };

            context.Videos.AddOrUpdate(video);

            context.SaveChanges();
        }
    }
}
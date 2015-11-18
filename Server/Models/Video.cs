using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoOnDemandApi.Server.Models
{
    public class Video
    {
        public Video()
        {

        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string YouTubeId { get; set; }
        public string VimeoId { get; set; }
        public VideoProviderType Type { get; set; }

    }
}
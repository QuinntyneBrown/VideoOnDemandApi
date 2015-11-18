using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Data;
using VideoOnDemandApi.Server.Data.Contracts;
using VideoOnDemandApi.Server.Models;

namespace VideoOnDemandApi.Server.Data
{
    public class VideoOnDemandContext : Common.Data.BaseDbContext, IVideoOnDemandContext
    {
        public VideoOnDemandContext()
            : base("videoOnDemandContext")
        {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Video> Videos { get; set; }

    }
}

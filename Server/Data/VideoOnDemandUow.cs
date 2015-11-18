using Common.Data;
using Common.Data.Contracts;
using VideoOnDemandApi.Server.Data.Contracts;
using VideoOnDemandApi.Server.Models;

namespace VideoOnDemandApi.Server.Data
{
    public class VideoOnDemandUow : Common.Data.BaseUow, IVideoOnDemandUow
    {
        public VideoOnDemandUow(VideoOnDemandContext videoOnDemandContext)
            : base(videoOnDemandContext)
        {
            
        }

        public IRepository<User> Users { get { return GetStandardRepo<User>(); } }

        public IRepository<Account> Account { get { return GetStandardRepo<Account>(); } }

        public IRepository<Role> Roles { get { return GetStandardRepo<Role>(); } }

        public IRepository<Group> Groups { get { return GetStandardRepo<Group>(); } }

        public IRepository<Session> Sessions { get { return GetStandardRepo<Session>(); } }

        public void SaveChanges()
        {
            
        }

    }
}

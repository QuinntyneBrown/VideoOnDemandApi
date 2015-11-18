using Common.Data.Contracts;
using VideoOnDemandApi.Server.Models;

namespace VideoOnDemandApi.Server.Data.Contracts
{
    public interface IVideoOnDemandUow
    {
        IRepository<User> Users { get; }

        IRepository<Role> Roles { get;}
        
        IRepository<Group> Groups { get; }

        IRepository<Session> Sessions { get; }

        void SaveChanges();
    }
}

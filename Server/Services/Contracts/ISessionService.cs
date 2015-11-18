using System.Threading.Tasks;
using VideoOnDemandApi.Server.Dtos;
using VideoOnDemandApi.Server.Models;

namespace VideoOnDemandApi.Server.Services.Contracts
{
    public interface ISessionService
    {
        TokenDto StartSession(int id);

        TokenDto StartSession(User user);

        void EndSession(int sessionId);

        Session GetSession(int sessionId);

        Session GetSession(User user);

        void UpdateSession(Session session);

        UserDto GetCurrentUser(int sessionId);

        Task<UserDto> GetCurrentUser(string username);
    }
}
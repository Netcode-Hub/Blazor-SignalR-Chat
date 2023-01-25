
using SignalRChat.Shared;

namespace SignalRChat.Server.Repository
{
    public interface IChatRepository
    {
        Task SaveToDatabase(string user, string message);
    }
}

using SignalRChat.Server.Data;
using SignalRChat.Shared;

namespace SignalRChat.Server.Repository
{
    public class ChatRepository : IChatRepository
    {
        private readonly AppDbContext appDbContext;

        public ChatRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task SaveToDatabase(string user, string message)
        {
            Chat chat = new Chat()
            {
                Username = user,
                Message = message,
            };

            appDbContext.Chats.Add(chat);
            await appDbContext.SaveChangesAsync();
        }
    }
}

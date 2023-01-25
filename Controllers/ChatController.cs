using Microsoft.AspNetCore.Mvc;
using SignalRChat.Server.Repository;

namespace SignalRChat.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatRepository chatRepository;

        public ChatController(IChatRepository chatRepository)
        {
            this.chatRepository = chatRepository;
        }

        public async Task SaveToDatabase(string username, string message)
        {
             await chatRepository.SaveToDatabase(username, message);

        }
    }
}

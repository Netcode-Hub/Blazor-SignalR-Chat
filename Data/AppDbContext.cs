using Microsoft.EntityFrameworkCore;
using SignalRChat.Shared;

namespace SignalRChat.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Chat> Chats { get; set; }
    }
}

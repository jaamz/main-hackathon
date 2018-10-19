using Microsoft.EntityFrameworkCore;

namespace Server
{
    public class HackathonDBContext : DbContext
    {
        public HackathonDBContext(DbContextOptions<HackathonDBContext> options) : base(options)
        {

        }

        public DbSet<AppUser>       appuser { get; set; }
        public DbSet<Jobs>          jobs { get; set; }
        public DbSet<Company>       company { get; set; }
        public DbSet<Channel>       channel { get; set; }

        public DbSet<Thread>        thread { get; set; }

        public DbSet<PostedMessage> postedmessage { get; set; }

    }
}
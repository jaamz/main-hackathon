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

        public DbSet<Collaboration>        collaboration { get; set; }

        public DbSet<Interview> interview { get; set; }

    }
}
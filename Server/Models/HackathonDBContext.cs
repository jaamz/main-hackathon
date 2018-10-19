using Microsoft.EntityFrameworkCore;

namespace Server
{
    public class HackathonDBContext : DbContext
    {
        public HackathonDBContext(DbContextOptions<HackathonDBContext> options) : base(options)
        {

        }

        public DbSet<AppUser>      appuser {get; set;}
        public DbSet<Jobs>         employee {get; set;}
        public DbSet<Company>      company {get; set;}

    }
}
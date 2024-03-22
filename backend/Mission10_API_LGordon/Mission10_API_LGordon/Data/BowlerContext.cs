using Microsoft.EntityFrameworkCore;

namespace Mission10_API_LGordon.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext() { }
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }
        public DbSet<BowlerInfo> Bowlers { get; set; }
        public DbSet<TeamInfo> Teams { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace cinemapandas.Models
{
    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions options) : base (options) { }

        public DbSet<User> Users { get; set; }
    }
}
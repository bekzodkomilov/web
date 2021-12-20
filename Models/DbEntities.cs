using Microsoft.EntityFrameworkCore;

namespace web.Models
{
      public class DbEntities: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbEntities(DbContextOptions options)
            : base(options) { }
    }
}
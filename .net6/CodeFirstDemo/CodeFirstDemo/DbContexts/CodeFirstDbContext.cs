using CodeFirstDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.DbContexts
{
    public class CodeFirstDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Gun> Gun { get; set; }
        public CodeFirstDbContext(DbContextOptions options):base(options)
        {
            
        }
        public CodeFirstDbContext()
        {
            
        }
    }
}

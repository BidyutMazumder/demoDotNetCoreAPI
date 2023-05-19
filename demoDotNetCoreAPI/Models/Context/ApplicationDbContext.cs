
using Microsoft.EntityFrameworkCore;

namespace demoDotNetCoreAPI.Models.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}

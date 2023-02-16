using clms_core.Models;
using Microsoft.EntityFrameworkCore;

namespace clms.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
        }
        public DbSet<User> Users { get; set; }
    }
}

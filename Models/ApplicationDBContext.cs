using Microsoft.EntityFrameworkCore;

namespace LoginApp.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<LoginA> LoginAs { get; set; }
    }
}

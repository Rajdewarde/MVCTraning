using Microsoft.EntityFrameworkCore;
using MVCTraning.Models; // तुमच्या Models चा Namespace

namespace MVCTraning.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Table चा Access देण्यासाठी DbSet (Step 4 चा भाग)
        public DbSet<Students> Students { get; set; }
    }
}
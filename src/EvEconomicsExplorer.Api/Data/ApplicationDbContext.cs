using EvEconomicsExplorer.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace EvEconomicsExplorer.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base (options)
        {
        }

        public DbSet<Comparison> Comparisons { get; set; } = null!;
    }
}

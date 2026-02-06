using Microsoft.EntityFrameworkCore;
using stock_finance_api.Models;

namespace stock_finance_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Use the strongly-typed DbContextOptions<T> so DI provides the correct options instance
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions) 
        {
            
        }

        public DbSet<Stock> Stock { get; set;  }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>()
                .Property(s => s.LastDiv)
                .HasPrecision(18, 2); // explicitly keep the default precision value and tell EF as well
        }
    }
}

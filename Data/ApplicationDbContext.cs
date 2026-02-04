using Microsoft.EntityFrameworkCore;
using stock_finance_api.Models;

namespace stock_finance_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
            
        }

        public DbSet<Stock> Stock { get; set;  }
        public DbSet<Comment> Comments { get; set; }
    }
}

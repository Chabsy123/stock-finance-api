using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using stock_finance_api.Models;

namespace stock_finance_api.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        // Use the strongly-typed DbContextOptions<T> so DI provides the correct options instance
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions) 
        {
            
        }

        public DbSet<Stock> Stock { get; set;  }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure Identity entity mappings (and their keys) are configured
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Portfolio>(x => x.HasKey(p => new { p.AppUserId, p.StockId }));

            modelBuilder.Entity<Portfolio>()
                .HasOne(u => u.AppUser)
                .WithMany(u => u.Portfolios)
                .HasForeignKey(p => p.AppUserId);

            modelBuilder.Entity<Portfolio>()
                .HasOne(u => u.Stock)
                .WithMany(u => u.Portfolios)
                .HasForeignKey(p => p.StockId);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            modelBuilder.Entity<Stock>()
                .Property(s => s.LastDiv)
                .HasPrecision(18, 2); // explicitly keep the default precision value and tell EF as well
        }
    }
}

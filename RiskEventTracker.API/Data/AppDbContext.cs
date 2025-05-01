using Microsoft.EntityFrameworkCore;
using RiskEventTracker.API.Models;

namespace RiskEventTracker.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<RiskEvent> RiskEvents { get; set; }
    }
}
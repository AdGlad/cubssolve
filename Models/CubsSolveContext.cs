using Microsoft.EntityFrameworkCore;

namespace CubsSolve.Models
{
    public class CubsSolveContext : DbContext
    {
        public CubsSolveContext(DbContextOptions<CubsSolveContext> options)
            : base(options)
        {
        }

        public DbSet<CubsSolveItem> CubsSolveItems { get; set; }
    }
}
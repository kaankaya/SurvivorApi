using Microsoft.EntityFrameworkCore;
using SurvivorApi.Entities;
using System.Data.Common;

namespace SurvivorApi.Data
{
    public class SurvivorApiContext : DbContext
    {
        public SurvivorApiContext(DbContextOptions<SurvivorApiContext> options) : base(options) { }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<Competitor> Competitors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>().HasMany(c => c.Competitors).WithOne(c => c.Category).HasForeignKey(c => c.CategoryId);
            base.OnModelCreating(modelBuilder);
        }
    }
}

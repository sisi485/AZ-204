using Microsoft.EntityFrameworkCore;

namespace CosmosEF
{
    public class FoodCosmosDbContext : DbContext
    {
        public DbSet<FoodItem> FoodItems { get; set; }
    
        public FoodCosmosDbContext(DbContextOptions<FoodCosmosDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
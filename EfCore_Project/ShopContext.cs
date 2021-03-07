using EfCore_Project.Mapping;
using EfCore_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore_Project
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            base.OnModelCreating(modelBuilder);
        }
  
    }
}

using EfCore_Project.Mapping;
using EfCore_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore_Project
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBiograpahy> AuthorBiograpahies { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCategoryMapping());
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new AuthorMapping());
            modelBuilder.ApplyConfiguration(new AuthorBiographyMapping());
            modelBuilder.ApplyConfiguration(new BookMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new BookCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
  
    }
}

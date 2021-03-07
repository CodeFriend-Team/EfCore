using EfCore_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore_Project.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.Property(x => x.Name).HasMaxLength(150);
            builder.Property(x => x.IsDeleted).HasColumnName("IsRemoved");
            builder.Property(x => x.IsInStock).HasColumnName("IsAvalibleInStoke");
            builder.HasOne(p => p.ProductCategory).WithMany(p => p.Product).HasForeignKey(p=>p.CategoryId);
        }
    }
}

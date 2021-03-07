using EfCore_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore_Project.Mapping
{
    public class AuthorMapping : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(225);
            builder.Property(x => x.LastName).HasMaxLength(225);
            builder.HasOne(x => x.AuthorBiograpahy).WithOne(x=>x.Author).HasForeignKey<AuthorBiograpahy>(x=>x.AuthorId);
        }
    }
}

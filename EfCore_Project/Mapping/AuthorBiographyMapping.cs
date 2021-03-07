using EfCore_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore_Project.Mapping
{
    public class AuthorBiographyMapping : IEntityTypeConfiguration<AuthorBiograpahy>
    {
        public void Configure(EntityTypeBuilder<AuthorBiograpahy> builder)
        {
            builder.ToTable("AuthorBiography");
            builder.HasKey(x=>x.Id);

            builder.Property(x => x.PlaceOfLiving).HasMaxLength(250);
            builder.Property(x => x.Biography).HasMaxLength(999999999);

        }
    }
}

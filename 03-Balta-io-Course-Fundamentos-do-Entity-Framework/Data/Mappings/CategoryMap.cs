using System;
using System.Collections.Generic;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category"); // Tabela
            
            builder.HasKey(x => x.Id);// Chave primária

            builder.Property(x => x.Id)// Identity
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(); // IDENTITY (1,1)
           
            builder.Property(x => x.Name) // Propriedades
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Slug)
                .IsRequired()
                .HasColumnName("Slug")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);
            
            builder.HasIndex(x => x.Slug, "IX_Category_Slug")// índices
                .IsUnique();
        }
    }
}

﻿using MB.Domain.ArticleCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Infrastructure.EFCore.Mappings
{
    public class ArticleCategoryMapping : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(255).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.CreationDate).IsRequired();

        }
    }
}

using Academy.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Persistence.EF.Mappings
{
    public class CourseCategoryMapping : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.ToTable("CourseCategories").HasKey(a => a.Id);
            builder.Property(a => a.Title).HasMaxLength(255).IsRequired();
            builder.HasOne(a => a.ParentCategory).WithMany(a=>a.ChildCategories);
        }
    }
}

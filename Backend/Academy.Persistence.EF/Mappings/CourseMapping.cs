using Academy.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Persistence.EF.Mappings
{
    public class CourseMapping : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses").HasKey(a => a.Id);
            builder.Property(a => a.Title).HasMaxLength(255).IsRequired();
            builder.HasOne(a => a.Category).WithMany().IsRequired();
        }
    }
}

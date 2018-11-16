using Academy.Domain.Model;
using Academy.Persistence.EF.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Persistence.EF
{
    public class AcademyContext : DbContext
    {
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public AcademyContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseCategoryMapping());
            modelBuilder.ApplyConfiguration(new CourseMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}

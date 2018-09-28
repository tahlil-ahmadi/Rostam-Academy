using Academy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Persistence.EF
{
    public class CourseCategoryRepository : ICourseCategoryRepository
    {
        private readonly AcademyContext context;
        public CourseCategoryRepository(AcademyContext context)
        {
            this.context = context;
        }
        public void Add(CourseCategory courseCategory)
        {
            context.CourseCategories.Add(courseCategory);
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Academy.Application.CourseCategories;

namespace Academy.Application
{
    public class CourseDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategoryDTO Category { get; set; }
    }
}

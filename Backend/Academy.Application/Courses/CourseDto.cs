using Academy.Application.CourseCategories;

namespace Academy.Application.Courses
{
    public class CourseDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategoryDTO Category { get; set; }
    }
}

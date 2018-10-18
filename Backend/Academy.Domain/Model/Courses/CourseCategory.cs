using System.Collections.Generic;

namespace Academy.Domain.Model.Courses
{
    public class CourseCategory
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategory ParentCategory { get; set; }
        public List<CourseCategory> ChildCategories { get; set; }
    }
}

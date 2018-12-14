using System.Collections.Generic;

namespace Academy.Application.CourseCategories
{
    public class CourseCategoryDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public List<CourseCategoryDTO> ChildCategories { get; set; }
    }
}

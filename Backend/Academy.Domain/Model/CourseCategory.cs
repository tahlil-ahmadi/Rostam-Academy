using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Domain.Model
{
    public class CourseCategory
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategory ParentCategory { get; set; }
        public List<CourseCategory> ChildCategories { get; set; }
    }
}

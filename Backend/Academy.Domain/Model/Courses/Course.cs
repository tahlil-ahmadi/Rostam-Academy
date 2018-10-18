using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain.Model.Courses;

namespace Academy.Domain.Model
{
    public class Course
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategory Category { get; set; }
    }
}

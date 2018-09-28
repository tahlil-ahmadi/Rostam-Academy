using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Domain.Model
{
    public interface ICourseCategoryRepository
    {
        void Add(CourseCategory courseCategory);
    }
}

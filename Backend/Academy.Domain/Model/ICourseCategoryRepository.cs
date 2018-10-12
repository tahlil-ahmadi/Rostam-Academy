using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Domain.Model
{
    public interface ICourseCategoryRepository
    {
        void Add(CourseCategory courseCategory);
        List<CourseCategory> GetAll();
        CourseCategory GetById(long id);
        void Delete(CourseCategory item);
    }
}

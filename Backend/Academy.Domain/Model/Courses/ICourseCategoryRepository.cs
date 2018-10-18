using System.Collections.Generic;

namespace Academy.Domain.Model.Courses
{
    public interface ICourseCategoryRepository
    {
        void Add(CourseCategory courseCategory);
        List<CourseCategory> GetAll();
        CourseCategory GetById(long id);
        void Delete(CourseCategory item);
    }
}

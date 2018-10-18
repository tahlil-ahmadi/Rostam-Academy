using System.Collections.Generic;

namespace Academy.Application.CourseCategories
{
    public interface ICourseCategoryService
    {
        void Create(string title);
        List<CourseCategoryDTO> GetAll();
        void Delete(long id);
    }
}
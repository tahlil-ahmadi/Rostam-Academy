using System.Collections.Generic;

namespace Academy.Application.CourseCategories
{
    public interface ICourseCategoryService
    {
        void Create(CreateCourseCategoryDTO dto);
        List<CourseCategoryDTO> GetAll();
        void Delete(long id);
    }
}
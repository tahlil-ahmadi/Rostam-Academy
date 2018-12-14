using System.Collections.Generic;
using System.Threading.Tasks;
using Academy.Application.Courses;

namespace Academy.Application.CourseCategories
{
    public interface ICourseCategoryService
    {
        void Create(CreateCourseCategoryDTO dto);
        void Update(ModifyCourseCategoryDTO dto);
        Task<List<CourseCategoryDTO>> GetAll();
        void Delete(long id);
    }
}
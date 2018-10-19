using System.Collections.Generic;
using Academy.Domain.Model;

namespace Academy.Application
{
    public interface ICourseCategoryService
    {
        void Create(CreateCourseCategoryDTO dto);
        List<CourseCategoryDTO> GetAll();
        void Delete(long id);
    }
}
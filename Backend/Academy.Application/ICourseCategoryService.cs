using System.Collections.Generic;
using Academy.Domain.Model;

namespace Academy.Application
{
    public interface ICourseCategoryService
    {
        void Create(CreateCourseCategoryDTO dto);
        void Update(ModifyCourseCategoryDTO dto);
        List<CourseCategoryDTO> GetAll();
        void Delete(long id);
    }
}
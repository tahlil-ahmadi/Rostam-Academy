using System.Collections.Generic;
using Academy.Domain.Model;

namespace Academy.Application
{
    public interface ICourseCategoryService
    {
        void Create(string title);
        List<CourseCategoryDTO> GetAll();
        void Delete(long id);
    }
}
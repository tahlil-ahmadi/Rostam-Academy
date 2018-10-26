using System.Collections.Generic;
using System.Threading.Tasks;
using Academy.Domain.Model;

namespace Academy.Application
{
    public interface ICourseCategoryService
    {
        void Create(CreateCourseCategoryDTO dto);
        void Update(ModifyCourseCategoryDTO dto);
        Task<List<CourseCategoryDTO>> GetAll();
        void Delete(long id);
    }
}
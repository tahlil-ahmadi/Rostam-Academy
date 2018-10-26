using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Domain.Model
{
    public interface ICourseCategoryRepository
    {
        void Add(CourseCategory courseCategory);
        //TODO: remove this update and move to unit of work
        void Update(CourseCategory courseCategory);
        Task<List<CourseCategory>> GetAll();
        CourseCategory GetById(long id);
        void Delete(CourseCategory item);
    }
}

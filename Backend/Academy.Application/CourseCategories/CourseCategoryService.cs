using System.Collections.Generic;
using Academy.Domain.Model.Courses;
using Mapster;

namespace Academy.Application.CourseCategories
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private ICourseCategoryRepository _repository;
        public CourseCategoryService(ICourseCategoryRepository repository)
        {
            this._repository = repository;
        }
        public void Create(string title)
        {
            var courseCategory = new CourseCategory()
            {
                Title = title
            };
            _repository.Add(courseCategory);
        }

        public List<CourseCategoryDTO> GetAll()
        {
            var data =  _repository.GetAll();
            return data.Adapt<List<CourseCategoryDTO>>();
        }

        public void Delete(long id)
        {
            var item = _repository.GetById(id);
            if (item != null)
                _repository.Delete(item);
        }
    }
}

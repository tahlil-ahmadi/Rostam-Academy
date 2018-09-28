using Academy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Application
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
    }
}

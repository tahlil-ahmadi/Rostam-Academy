using Academy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Application
{
    public class CourseCategoryService
    {
        public void Create(string title)
        {
            var courseCategory = new CourseCategory()
            {
                Title = title
            };

            //...SAVE COURSECATEGORY INTO DATABASE :)
        }
    }
}

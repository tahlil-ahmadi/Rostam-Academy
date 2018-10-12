using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Application
{
    public class CourseCategoryDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public List<CourseCategoryDTO> ChildCategories { get; set; }
    }
}

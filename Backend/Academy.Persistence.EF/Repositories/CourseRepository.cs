using Academy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Framework.Core.DataFiltering;

namespace Academy.Persistence.EF
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AcademyContext _context;
        public CourseRepository(AcademyContext context)
        {
            this._context = context;
        }

        public PagedResult<Course> Get(FilterRequest filter)
        {
            var data = _context.Courses
                                .OrderByDescending(a => a.Id)
                                .Skip(filter.Skip)
                                .Take(filter.Take)
                                .ToList();
            var count = _context.Courses.Count();
            return new PagedResult<Course>(data, count);
        }
    }
}

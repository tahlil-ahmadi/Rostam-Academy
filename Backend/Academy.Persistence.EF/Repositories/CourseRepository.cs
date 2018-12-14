using System.Linq;
using System.Threading.Tasks;
using Academy.Domain.Model;
using Framework.Core.DataFiltering;

namespace Academy.Persistence.EF.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AcademyContext _context;
        private readonly IFilterHelper _filterHelper;

        public CourseRepository(AcademyContext context, IFilterHelper filterHelper)
        {
            this._context = context;
            _filterHelper = filterHelper;
        }

        public async Task<PagedResult<Course>> Get(IFilter filter)
        {
            var query = _context.Courses
                                .OrderByDescending(a => a.Id)
                                .AsQueryable();
            return await _filterHelper.ApplyAsync(query, filter);
        }
    }
}

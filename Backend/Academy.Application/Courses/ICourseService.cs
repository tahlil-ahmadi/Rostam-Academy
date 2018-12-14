using System.Threading.Tasks;
using Framework.Core.DataFiltering;

namespace Academy.Application.Courses
{
    public interface ICourseService
    {
        Task<PagedResult<CourseDto>> Get(IFilter filter);
    }
}

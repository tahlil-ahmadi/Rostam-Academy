using System.Collections.Generic;
using System.Text;
using Framework.Core.DataFiltering;

namespace Academy.Application
{
    public interface ICourseService
    {
        PagedResult<CourseDto> Get(FilterRequest filter);
    }
}

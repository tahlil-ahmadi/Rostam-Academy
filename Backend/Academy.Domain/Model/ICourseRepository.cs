using System;
using System.Collections.Generic;
using System.Text;
using Framework.Core.DataFiltering;

namespace Academy.Domain.Model
{
    public interface ICourseRepository
    {
        PagedResult<Course> Get(FilterRequest filter);
    }
}

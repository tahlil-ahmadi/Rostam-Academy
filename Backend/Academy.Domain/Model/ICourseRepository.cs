using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.DataFiltering;

namespace Academy.Domain.Model
{
    public interface ICourseRepository
    {
        Task<PagedResult<Course>> Get(IFilter filter);
    }
}

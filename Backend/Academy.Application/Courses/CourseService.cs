using System.Collections.Generic;
using System.Threading.Tasks;
using Academy.Domain.Model;
using Framework.Core.DataFiltering;
using Mapster;

namespace Academy.Application.Courses
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public async Task<PagedResult<CourseDto>> Get(IFilter filter)
        {
            var result = await _repository.Get(filter);
            var convertedData = result.Data.Adapt<List<CourseDto>>();
            return new PagedResult<CourseDto>(convertedData, result.Total);
        }
    }
}
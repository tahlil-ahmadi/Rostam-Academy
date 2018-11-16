using System;
using System.Collections.Generic;
using Academy.Domain.Model;
using Framework.Core.DataFiltering;
using Mapster;

namespace Academy.Application
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public PagedResult<CourseDto> Get(FilterRequest filter)
        {
            var result = _repository.Get(filter);
            var convertedData = result.Data.Adapt<List<CourseDto>>();
            return new PagedResult<CourseDto>(convertedData, result.Total);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Academy.Application.Courses;
using Framework.Core.DataFiltering;
using Framework.Kendo;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Interface.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ICourseService _service;
        public CoursesController(ICourseService service)
        {
            _service = service;
        }

        //public PagedResult<CourseDto> Get([FromQuery]FilterRequest request)
        public async Task<PagedResult<CourseDto>> Get([DataSourceRequest]DataSourceRequest request)
        {
            var filter = new KendoFilter(request);
            return await _service.Get(filter);
        }
    }
}

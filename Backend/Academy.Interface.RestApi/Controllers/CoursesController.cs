using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Framework.Core.DataFiltering;
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

        public PagedResult<CourseDto> Get([FromQuery]FilterRequest request)
        {
            return _service.Get(request);
        }
    }
}

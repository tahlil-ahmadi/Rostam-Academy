using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Interface.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        public GridResult<CourseDto> Get(long take, long skip)
        {
            //TODO:get from database
            var data = new List<CourseDto>();
            for (int i = 0; i < take; i++)
            {
                var random = new Random(Guid.NewGuid().GetHashCode()).Next(1, 10000);
                data.Add(new CourseDto()
                {
                    Id = random,
                    Title = $"title{random}"
                });
            }
            return new GridResult<CourseDto>(data,50);
        }
    }
}

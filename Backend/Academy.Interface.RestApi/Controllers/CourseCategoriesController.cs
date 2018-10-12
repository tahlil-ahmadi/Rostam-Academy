using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Academy.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Interface.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController : ControllerBase
    {
        private ICourseCategoryService _service;
        public CourseCategoriesController(ICourseCategoryService service)
        {
            this._service = service;
        }

        public List<Course> Get()
        {
            var data = new List<Course>
            {
                new Course() {Id = 1, Title = "Web Programming"},
                new Course() {Id = 2, Title = "Mobile Programming"},
                new Course() {Id = 3, Title = "Desktop Programming"}
            };
            return data;
        }
    }
}

using System;
using System.Collections.Generic;
using Academy.Application.Classes;
using Academy.Domain.Model.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Interface.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private IClassService _service;
        public ClassesController(IClassService service)
        {
            this._service = service;
        }

        public List<Class> Get()
        {
            return _service.GetAll();
        }
        [HttpPost]
        public void Post(ClassDto dto)
        {
            var @class = new Class()
            {
                //Number = dto.Number,
                //Title = dto.Title
                Number = 2,
                Title = "MVC"
            };
            _service.Create(@class);
        }

        [Route("{id}")]
        public void Delete(long id)
        {
            _service.Delete(id);
        }
    }
}

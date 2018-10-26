﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
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

        public List<CourseCategoryDTO> Get()
        {
            return _service.GetAll();
        }

        [HttpPost]
        public void Post(CreateCourseCategoryDTO dto)
        {
            _service.Create(dto);
        }

        [HttpPut]
        [Route("{id}")]
        public void Put(long id, ModifyCourseCategoryDTO dto)
        {
            dto.Id = id;
            _service.Update(dto);
        }

        [Route("{id}")]
        public void Delete(long id)
        {
            _service.Delete(id);
        }
    }
}

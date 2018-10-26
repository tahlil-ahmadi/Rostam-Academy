﻿using Academy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Academy.Persistence.EF
{
    public class CourseCategoryRepository : ICourseCategoryRepository
    {
        private readonly AcademyContext context;
        public CourseCategoryRepository(AcademyContext context)
        {
            this.context = context;
        }
        public void Add(CourseCategory courseCategory)
        {
            context.CourseCategories.Add(courseCategory);
            context.SaveChanges();
        }

        public void Update(CourseCategory courseCategory)
        {
            //TODO: remove this update and move to unit of work
            context.SaveChanges();
        }

        public List<CourseCategory> GetAll()
        {
            //TODO: we should only load roots (temporally)
            return context.CourseCategories.ToList()
                          .Where(a=>a.ParentCategory == null)
                          .ToList();
        }

        public CourseCategory GetById(long id)
        {
            return context.CourseCategories.FirstOrDefault(a => a.Id == id);
        }

        public void Delete(CourseCategory item)
        {
            context.CourseCategories.Remove(item);
            context.SaveChanges();
        }
    }
}

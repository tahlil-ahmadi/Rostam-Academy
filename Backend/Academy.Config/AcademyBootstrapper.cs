using Academy.Application;
using Academy.Domain.Model;
using Academy.Persistence.EF;
using Microsoft.Extensions.DependencyInjection;
using System;
using Academy.Application.Classes;
using Academy.Application.CourseCategories;
using Academy.Domain.Model.Classes;
using Academy.Domain.Model.Courses;
using Academy.Persistence.EF.Repositories;

namespace Academy.Config
{
    public static class AcademyBootstrapper
    {
        public static void WireUp(IServiceCollection services)
        {
            //TODO: Singleton ?? O_o
            services.AddSingleton<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddSingleton<ICourseCategoryService, CourseCategoryService>();
            services.AddSingleton<IClassRepository, ClassRepository>();
            services.AddSingleton<IClassService, ClassService>();
            services.AddSingleton<AcademyContext>();
        }
    }
}

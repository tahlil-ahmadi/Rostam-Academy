using Academy.Application;
using Academy.Domain.Model;
using Academy.Persistence.EF;
using Microsoft.Extensions.DependencyInjection;
using System;
using Academy.Application.CourseCategories;
using Academy.Application.Courses;
using Academy.Persistence.EF.Repositories;
using Framework.Core.DataFiltering;
using Framework.Kendo;
using Microsoft.EntityFrameworkCore;

namespace Academy.Config
{
    public static class AcademyBootstrapper
    {
        public static void AddAcademy(this IServiceCollection services, AcademyOptions options)
        {
            services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseCategoryService, CourseCategoryService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddDbContext<AcademyContext>(a=> a.ConfigForAcademy(options.ConnectionString));
            services.AddSingleton<IFilterHelper, KendoFilterHelper>();
        }
    }
}

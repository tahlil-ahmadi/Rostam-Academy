using Academy.Application;
using Academy.Domain.Model;
using Academy.Persistence.EF;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;

namespace Academy.Config
{
    public static class AcademyBootstrapper
    {
        public static void AddAcademy(this IServiceCollection services, AcademyOptions options)
        {
            services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddScoped<ICourseCategoryService, CourseCategoryService>();
            services.AddDbContext<AcademyContext>(a=> a.ConfigForAcademy(options.ConnectionString));
        }
    }
}

using Academy.Application;
using Academy.Domain.Model;
using Academy.Persistence.EF;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Academy.Config
{
    public static class AcademyBootstrapper
    {
        public static void WireUp(IServiceCollection services)
        {
            //TODO: Singleton ?? O_o
            services.AddSingleton<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddSingleton<ICourseCategoryService, CourseCategoryService>();
            services.AddSingleton<AcademyContext>();
        }
    }
}

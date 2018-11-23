using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Academy.Config;
using Academy.Domain.Model;
using Academy.Interface.RestApi.Filters;
using Academy.Persistence.EF;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Academy.Interface.RestApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private AcademyOptions options;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            options = configuration.Get<AcademyOptions>();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc(config =>
                {
                    config.Filters.Add(new AuthorizeFilter());
                    config.Filters.Add(new YekeFilter());
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAcademy(options);

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(opt =>
                {
                    opt.Authority = "http://localhost:5000";
                    opt.ApiName = "academy-api";
                    opt.RequireHttpsMetadata = false;
                });
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
            {
                builder.WithOrigins(options.TrustedOrigins)
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}

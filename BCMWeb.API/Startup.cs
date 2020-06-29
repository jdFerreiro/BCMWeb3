﻿using AutoMapper;
using BCMWeb.Application.Services;
using BCMWeb.Infrastructure.Data;
using BCMWeb.Infrastructure.Filters;
using BCMWeb.Infrastructure.Services;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Globalization;

namespace BCMWeb.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddLocalization(options =>
            {
                options.ResourcesPath = "Resources";
            });

            services.AddInfraestructure();
            services.AddApplication();

            services.AddControllers(options =>
            {
                options.Filters.Add<GlobalExceptionFilter>();
            }).AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            })
                .ConfigureApiBehaviorOptions(options =>
                {
                    // options.SuppressModelStateInvalidFilter = true;
                });

            services.AddDbContext<BcmWebToolsContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddMvc(options =>
            {
                options.Filters.Add<ValidationFilter>();
            })
                .AddFluentValidation(options =>
                {
                    options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
                });

            var supportedCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("es-VE")
            };

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

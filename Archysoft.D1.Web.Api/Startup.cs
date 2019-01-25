﻿using Archysoft.D1.Data;
using Archysoft.D1.Model.Auth;
using Archysoft.D1.Model.Repositories.Abstract;
using Archysoft.D1.Model.Repositories.Concrete;
using Archysoft.D1.Model.Services.Abstract;
using Archysoft.D1.Model.Services.Concrete;
using Archysoft.D1.Web.Api.Utilities;
using Archysoft.D1.Web.Api.Utilities.Filtres;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Archysoft.D1.Web.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>();

            services.AddMvc(
                config =>
                {
                    config.Filters.Add(new ValidateModelStateFilter());

                }).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<LoginModel>());


            //Services
            services.AddTransient<IAuthService, AuthService>();

            //Repositories
            services.AddTransient<IDatabaseInitializator, DatabaseInitializator>();
            services.AddTransient<IUserRepository, UserRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IDatabaseInitializator databaseInitializator)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                databaseInitializator.Initialize();
            }
            else
            {
                app.UseHsts();
            }

            app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

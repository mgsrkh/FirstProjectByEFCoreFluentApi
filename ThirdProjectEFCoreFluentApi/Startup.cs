using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ThirdProjectEFCoreFluentApi.ApplicationServices.IServices;
using ThirdProjectEFCoreFluentApi.ApplicationServices.Services;
using ThirdProjectEFCoreFluentApi.Contexts;
using ThirdProjectEFCoreFluentApi.InferaStructure.IRepositories;
using ThirdProjectEFCoreFluentApi.InferaStructure.Repositories;

namespace ThirdProjectEFCoreFluentApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();
            services.AddSwaggerGen();

            services.AddDbContext<ProjectContext>(option => option
            .UseSqlServer(_configuration["ConnectionString"]));

            //Dependency Injection Service Registartion
            services.AddScoped<IVendorRepository, VendorRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IVendorService, VendorService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Test1 Api v1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

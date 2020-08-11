using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using TestingService.Api.Mapping;
using TestingService.Domain.Repositories;
using TestingService.Domain.Services;

namespace TestingService.Api
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
            services.AddControllers();
            services.AddAutoMapper(c => c.AddProfile<AutoMapping>(), typeof(Startup));

            services.Configure<TestRepositoryOptions>(Configuration.GetSection(nameof(TestRepositoryOptions)));
            services.AddSingleton(p => p.GetRequiredService<IOptions<TestRepositoryOptions>>().Value);
            services.AddSingleton<ITestRepository, TestRepository>();
            services.AddSingleton<ITestAdministrationService, TestAdministrationService>();

            services.Configure<SessionRepositoryOptions>(Configuration.GetSection(nameof(SessionRepositoryOptions)));
            services.AddSingleton(p => p.GetRequiredService<IOptions<SessionRepositoryOptions>>().Value);
            services.AddSingleton<ISessionRepository, SessionRepository>();
            services.AddSingleton<ISessionService, SessionService>();
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

using HexaMazeRetreat.Blazor.DataAccess;
using HexaMazeRetreat.Blazor.Helpers;
using HexaMazeRetreat.Blazor.Validators;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HexaMazeRetreat.Blazor
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2021", new OpenApiInfo { Title = "HexaMazeRetreat", Version = "v2021" });
            });
            services.AddMemoryCache();
            services.AddDbContext<HexaMazeRetreatDbContext>();
            services.AddScoped<LevelsValidator>();
            services.AddScoped<PlaysHelper>();
            services.AddScoped<LevelsHelper>();
            services.AddScoped<LevelBuilderHelper>();
            services.AddSingleton<GraphicsCacheHelper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v2021/swagger.json", "HexaMazeRetreat v2021"));

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
                endpoints.MapControllers();
            });
        }
    }
}
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using FarmFreshApiService.Interfaces;
using FarmFreshApiService.Services;
using FarmFreshApiService.Managers;
using FarmFreshApiService.Utils;
using FirebaseAdmin;

namespace FarmFreshApiService
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
            //Read FI Swift Code, FI VID, FI Code from app settings
            SecurityConstants.Email =
                Configuration.GetSection("ServerInfo").GetValue<string>("Email");

            SecurityConstants.Contact =
                Configuration.GetSection("ServerInfo").GetValue<string>("Contact");

            SecurityConstants.Location =
                Configuration.GetSection("ServerInfo").GetValue<string>("Location");

            // Read DB Conn string
            Constants.DatabaseUtils.SQL_CONNECTION_STRING =
                SecurityManager.CreateSecureDBConnectionString(Configuration.GetSection("ConnectionStrings").GetValue<string>("PrimaryDB"));

            services.AddCors(o => o.AddPolicy("AllowAnyOrigins", builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));


            services.AddControllers();
            services.AddTransient<IDataAccessService, DataAccessService>();
         
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FarmFreshApiService", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FarmFreshApiService v1"));
            }

            app.UseRouting();

            app.UseCors("AllowAnyOrigins");

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

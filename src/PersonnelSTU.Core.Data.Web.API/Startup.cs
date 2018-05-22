using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PersonnelSTU.Core.Data.Infrastructure;
using PersonnelSTU.Core.Data.Repositories;

namespace PersonnelSTU.Core.Data.Web.API
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
            services.AddMvc();

            services.AddDbContext<PersonnelStuCoreDbContext>(options => options
                .UseSqlServer(Environment.GetEnvironmentVariable("FAKE_DB_CONNECTION_STRING") ?? throw new InvalidOperationException()));

            services.AddScoped<PersonnelStuCoreDbContext, PersonnelStuCoreDbContext>();
            services.AddScoped(typeof(IPersonnelSTUCoreEntityRepository<>), typeof(PersonnelSTUCoreEntityRepository<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.DataLayer.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace demo
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Configuration = new ConfigurationBuilder()
            // .SetBasePath(env.ContentRootPath)
            // .AddJsonFile("appsettings.json",optional:false,reloadOnChange: true)
            // .Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SchoolContext>(option => option.UseSqlServer("Data Source=.;Initial Catalog=gentelella;Integrated Security=True"));
            // services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<SchoolContext>();

            services.AddTransient<IUserLogic, UserLogic>();

            services.AddMvc();



            // services.AddTransient<ILogger, Logger>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //  app.Run(async context =>
            // {
            //     await context.Response.WriteAsync("Hello from 2nd delegate.");
            // });
            loggerFactory.AddDebug(LogLevel.Warning);
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }

            app.UseStaticFiles();
            app.UseMvc((routes) =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}

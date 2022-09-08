using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
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
            services.AddControllersWithViews();
            //services.AddMvc();  // ALSO, we can add MVC like this
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
                app.UseExceptionHandler("/Home/Error");
            }

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my first middleware\n");

            //    await next();

            //    await context.Response.WriteAsync("Hello from my first middleware Response\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my Second middleware\n");

            //    await next();

            //    await context.Response.WriteAsync("Hello from my second middleware Response\n");

            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my third middleware\n");

            //    await next();
            //});

            app.UseStaticFiles();

            app.UseRouting();  // here, order is very important..!!


            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/", async context =>
            //    {
            //        if(env.IsDevelopment())
            //            await context.Response.WriteAsync("Hello from DEV");
            //        else if(env.IsProduction())
            //            await context.Response.WriteAsync("Hello from PROD");
            //        else if (env.IsStaging()) 
            //            await context.Response.WriteAsync("Hello from STAG");
            //        else
            //            await context.Response.WriteAsync(env.EnvironmentName);

            //        // ALSO. i can write as if(env.IsEnvironmwnt("Develop"))
            //        //{
            //        //    await context.Response.WriteAsync("Hello from DEV");
            //        //}
            //    });
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

        }
    }
}

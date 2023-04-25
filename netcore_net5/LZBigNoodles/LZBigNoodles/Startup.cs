using LZBigNoodles.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LZBigNoodles
{
    public class Startup
    {
        public IConfiguration Configuration { get;  }
        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddTransient<INoodleRepository, NoodleRepository>();
            services.AddTransient<IFeedbackRepository,FeedbackRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //旧版本需要在services.AddMvc方法中添加‘options => options.EnableEndpointRouting = false’
            app.UseMvc(route =>
            {
                route.MapRoute("default", "{controller=Home}/{action=Index}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });


            //新版本
            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}"
            //        );
            //    endpoints.MapControllers();//特征注释路由
            //    endpoints.MapDefaultControllerRoute();//传统路由
            //    endpoints.MapGet("/test", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello test!");
            //    });
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});




        }
    }
}

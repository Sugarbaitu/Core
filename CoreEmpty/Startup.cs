using CoreEmpty.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CoreEmpty
{
    public class Startup
    {

        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// <summary>
        /// 管理组件依赖
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddTransient<INoodleRepository, NoodleRepository>();
            services.AddTransient<IFeedbackRepository, FeedbackRepository>();


            //单例
            //services.AddSingleton<INoodleRepository, MockNoodleRepository>();
            //复杂
            //services.AddScoped<INoodleRepository, MockNoodleRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// 配置系统http请求通道
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {





            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}"
            //        )
            //   });


            app.UseEndpoints(endpoints =>
            {
                //默认路由方法启用
                //endpoints.MapDefaultControllerRoute();
                //特性路由访问
                //endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );

                //endpoints.MapGet("/test", async context =>
                //{
                //    await context.Response.WriteAsync("Hello formTest");
                //});

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});


            });
        }
    }
}

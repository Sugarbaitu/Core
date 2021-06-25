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

namespace CoreEmpty
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// <summary>
        /// �����������
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();
            services.AddTransient<INoodleRepository, MockNoodleRepository>();
            //����
            //services.AddSingleton<INoodleRepository, MockNoodleRepository>();
            //����
            //services.AddScoped<INoodleRepository, MockNoodleRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// ����ϵͳhttp����ͨ��
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
                //Ĭ��·�ɷ�������
                //endpoints.MapDefaultControllerRoute();
                //����·�ɷ���
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

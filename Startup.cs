using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautySPA.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ONLNSTR.Data;
using ONLNSTR.Data.Mocks;
using ONLNSTR.Data.Models;
using ONLNSTR.Data.Repository;

namespace BeautySPA
{
    public class Startup
    {
        private IConfigurationRoot _confsting;

        public Startup(IHostingEnvironment hostEnv) {
            _confsting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confsting.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllWatches, WatchRepository>();
            services.AddTransient<IWatchesCatecory, CategoryRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopWatch.GetShop(sp));

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();

           
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DbObjects.Initial(content); 
            }
            
        }
    }
}

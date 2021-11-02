using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Data.Models.FoodMenus;
using DataServices.Services;

namespace RamenOkiDoki
{
    public class Startup
    {
        public IWebHostEnvironment Env { get; set; }

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            
            Globals.CartItemsList = new List<OrderItem>();
            Globals.FoodCategoriesList = new List<FoodMenu.FoodCategory>();
            Globals.FoodItemsList = new List<FoodMenu.FoodItem>();
            Globals.FoodCategory = new FoodMenu.FoodCategory();
            Globals.OrderSubTotalCost = 0.00;
            Env = env;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        //this is the usage of Dependency Injection
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<MenuEndpointService>();


            if (Env.IsDevelopment())
            {
                services.AddControllersWithViews().AddRazorRuntimeCompilation();
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               // app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //MiddleWare - influence how the whole response for the request from browser will be.
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //process through which the applicaiton matches the requested URL path and executes the related Controller and Aciton.
            app.UseRouting();

            app.UseAuthorization();

            //endpoints can be MVC, Razor Pages and SignalR
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

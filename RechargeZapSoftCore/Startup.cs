using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RechargeZapSoftCore
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddHttpContextAccessor();
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc().AddSessionStateTempDataProvider();

            //services.AddSession();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(1000);//You can set Time   
            });
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("*")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseCors();
            var options = new RewriteOptions()
    .AddRedirectToHttpsPermanent();

            app.UseRewriter(options);
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
          name: "jio",
          template: "{controller=Jio}/{action=Jio}/{id?}");
                routes.MapRoute(
   name: "airtel",
   template: "{controller=Airtel}/{action=Airtel}/{id?}");
                routes.MapRoute(
name: "bsnl",
template: "{controller=BSNL}/{action=BSNL}/{id?}");
                routes.MapRoute(
name: "vi",
template: "{controller=VI}/{action=VI}/{id?}");
                routes.MapRoute(
name: "vi",
template: "{controller=DTH}/{action=DTH}/{id?}");
                routes.MapRoute(
name: "vi",
template: "{controller=FASTag}/{action=FASTag}/{id?}");
                routes.MapRoute(
name: "vi",
template: "{controller=Electricity}/{action=Electricity}/{id?}");
                routes.MapRoute(
       name: "API",
       template: "api/[controller]/{apiname}",
       defaults: new { controller = "Recharge", action = "getOperator" });
            });
        }
    }
}

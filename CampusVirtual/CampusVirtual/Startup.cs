using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CampusVirtual
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<CampusContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddIdentity<Usuario, IdentityRole>()
                .AddEntityFrameworkStores<CampusContext>();
            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Ingresar");
            services.AddTransient<CampusContext, CampusContext>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes => routes.MapRoute(
                          name: "CampusRouting",
                          template: "{controller}/{action}/{id?}",
                          defaults: new { controller = "Account", action = "Ingresar" }
                          ));
        }
    }
}

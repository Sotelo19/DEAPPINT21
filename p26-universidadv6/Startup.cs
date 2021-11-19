using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using p21_universidadv1.Data;

using Microsoft.EntityFrameworkCore;
using p21_universidadv1.Servicio;

// Agregamos
using p21_universidadv1.Modelo; 
using Microsoft.AspNetCore.Identity ;
using Microsoft.AspNetCore.Mvc.Authorization;


namespace p21_universidadv1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Modficamos 
            services.AddRazorPages()
            .AddMvcOptions(options => options.Filters.Add(new AuthorizeFilter()));

            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddScoped<ServicioEstudiantes>();
            services.AddScoped<ServicioInstructores>();
            services.AddScoped<ServicioCursos>();
            services.AddScoped<ServicioDepartamentos>();
            services.AddScoped<ServicioInscripciones>();
            services.AddScoped<ServicioOficinaAsignadas>();
            services.AddScoped<ServicioAsignacionCursos>();
            services.AddDbContext<UniContexto>(opciones =>
            opciones.UseSqlite(Configuration.GetConnectionString("ConexionBD")));

            // Agregamos
             services.AddDefaultIdentity<Usuario>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<UniContexto>();
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();
            // agregamos
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); // Agregamos
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}

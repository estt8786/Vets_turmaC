using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ClinicaVet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //
        //injecao de dependencias 23-03-2020
        //a configurar o SQL server entre outros
        //foi copiado do ficheiro de correção do professor!!!!!!
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

            //****************************************************************************
            // especificação do 'tipo' e 'localização' da BD
            services.AddDbContext<VetsDB>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("ConnectionDB")));
            //****************************************************************************

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //23-03-2020
            //especificar as ROTAS -> como aceder aos recursos
            //em particular, o Controller por defeito e o Metodo por defeito, bem como o parametro de "pesquisa"
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

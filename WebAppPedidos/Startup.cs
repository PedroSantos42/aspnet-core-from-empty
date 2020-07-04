using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAppPedidos.Models;

namespace WebAppPedidos
{
    public class Startup
    {
        static List<Pedido> pedidos = new List<Pedido>() {
            new Pedido(1, "Bolacha", 100, 4, new DateTime(), "João"),
            new Pedido(1, "Arroz", 150, 6.5, new DateTime(), "Maria")
        };

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "pedido",
                    pattern: "{controller=Pedido}/{action=ListarPedidos}/{id?}");
            });
        }
    }
}
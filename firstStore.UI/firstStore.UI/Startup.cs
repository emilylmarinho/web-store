using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstStore.UI.infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace firstStore.UI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.AddSingleton(); //instância unica
            services.AddScoped<Data.FirstStoreDataContext>(); //escopo por requisição/ciclo de vida da requisição
            //services.AddTransient(); //toda a vez que é necessário ele sobe uma nova instância
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Data.FirstStoreDataContext ctx)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                Data.DbInitializer.Init(ctx);
            }

            app.UseStaticFiles();

            app.UseNodeModules(env.ContentRootPath);

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("Recurso não encontrado!");
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace firstStore.UI.infra
{
    public static class ApplicationBuilderExtensions
    {

        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string root)
        {
            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            var path = Path.Combine(root, "node_modules");
            options.FileProvider = new PhysicalFileProvider(path);
            app.UseStaticFiles(options);
            return app;
        }
    }
}

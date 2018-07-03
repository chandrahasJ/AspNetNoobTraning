using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmptyProjectTrail101
{
    //Notes :  We cannot view csproj file in solution explorer 
    //         To view csproj file we must right click on solution name -> Edit <ProjectName>.csproj
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ILoggerFactory loggerFactory)
        {
            /* Middleware */

            //Adding Logging in Console...
           // loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                //Show detailed error in Develpoment version
                app.UseDeveloperExceptionPage();
            }

            //app.UseDefaultFiles(); // Enables use of default file name
            //index.html, default.aspx etc...
            //app.UseStaticFiles(); // Enables use of Static files from wwwroot


            // All the static file related middle ware will be enabled 
            // excluding Directory Browsing..
            // we have to manually enable it...
            app.UseFileServer(enableDirectoryBrowsing: env.IsDevelopment());

            app.Run(async (context) =>
            {
                
                //throw new Exception("Cj is breaking things");
                await context.Response.WriteAsync($"{ GreetingPackage.Greets.GreetPeopleByName("Chandrahas Poojari") }");
            });
        }
    }
}


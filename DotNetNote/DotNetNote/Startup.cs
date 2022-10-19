﻿namespace DotNetNote
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseStaticFiles();
            
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    //await context.Response.WriteAsync("Hello World!");
                    await context.Response.WriteAsync("안녕하세요.");
                });
            });
        }
    }
}

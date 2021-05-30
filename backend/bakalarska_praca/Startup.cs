using bakalarska_praca.Controllers;
using bakalarska_praca.Extensions;
using bakalarska_praca.Models;
using bakalarska_praca.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;

namespace bakalarska_praca
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
            services.AddControllers();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); //vytvorenie lokalnej databazy
            services.AddHttpsRedirection(options =>         //presmerovanie http => https
            {
                options.RedirectStatusCode = (int)HttpStatusCode.PermanentRedirect;
                options.HttpsPort = 44386;
            });
          
            services.AddHsts(options =>         //tvorba HSTS
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(365);
            });
            services.ConfigureCors();
            services.ConfigureIISIntegration();
            services.ConfigureAuth();

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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            var options = new RewriteOptions().AddRedirectToHttps(StatusCodes.Status301MovedPermanently, 44386);        //redirect to https
            app.UseRewriter(options);

            app.UseStaticFiles();       
            app.UseCors("CorsPolicy");                                  //povolenie externych poziadaviek 
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

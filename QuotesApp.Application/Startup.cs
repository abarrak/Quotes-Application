using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using QuotesApp.Application.Configurations;
using QuotesApp.Application.DTOs;
using QuotesApp.Domain.Auth;
using QuotesApp.Domain.Auth.Models;
using QuotesApp.Domain.BusinessLogic;
using QuotesApp.Domain.Contracts;
using QuotesApp.Domain.Contracts.Infrastructure;
using QuotesApp.Infrastructure;
using QuotesApp.Infrastructure.Repositories;

namespace QuotesApp.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime.
        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionString));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc()
                    .AddMvcLocalization()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromHours(1);
                options.SlidingExpiration = true;

                // If the LoginPath isn't set, ASP.NET Core defaults the path to /Account/Login.
                //
                options.LoginPath = "/api/accounts/login";

                // If the AccessDeniedPath isn't set, ASP.NET Core defaults the path to /Account/AccessDenied.
                //
                options.AccessDeniedPath = "/api/accounts/access-denied";

                // Redirection settings ..
                options.Events.OnRedirectToLogin = ctx =>
                {
                    if (ctx.Request.Path.StartsWithSegments("/api") && ctx.Response.StatusCode == 200)
                    {
                        ctx.Response.StatusCode = 401;
                        return Task.FromResult<object>(null);
                    }

                    ctx.Response.Redirect(ctx.RedirectUri);
                    return Task.FromResult<object>(null);
                };
            });

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            services.AddSingleton<IMapper>(Mappings.Setup());

            services.AddTransient<IEmailSender, EmailSender>();

            services.AddScoped(typeof(IStringLocalizer<>), typeof(StringLocalizer<>));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IQuotesRepository, QuotesRepository>();
            services.AddScoped<IQuotesManager, QuotesManager>();
        }

        // This method gets called by the runtime.
        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsProduction())
            {
                // The default HSTS value is 30 days.
                // You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMiddleware<ExceptionHandler>();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
            app.UseRequestLocalization(options => options.AddSupportedCultures("en", "ar"));

            app.UseSpaStaticFiles();
            // app.UseSpa(spa =>
            // {
            //     // To learn more about options for serving an Angular SPA from ASP.NET Core,
            //     // see https://go.microsoft.com/fwlink/?linkid=864501
            //     //
            //     spa.Options.SourcePath = "ClientApp";
            // 
            //     if (env.IsDevelopment())
            //     {
            //         spa.UseAngularCliServer(npmScript: "start");
            //     }
            // });
        }
    }
}

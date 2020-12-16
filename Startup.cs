using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using pos.Models;
using pos.Models.CustomValidation;
using POS.Models;
using Microsoft.Extensions.Hosting;

namespace POS
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
               


                services.AddSingleton<IFileProvider>(  
            new PhysicalFileProvider(  
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));  

                services.AddTransient<IProductRepository,EfProductRepository>();
                services.AddTransient<IUserRepository,EfUserRepository>();

                services.AddIdentity<User, Role >(options =>
                {
                    options.User.RequireUniqueEmail= true;
                    options.User.AllowedUserNameCharacters="abcçdefgğhıijklmnoöpqrsştuüvwxyzABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ0123456789-._";
                    options.Password.RequireDigit = false;
		            options.Password.RequiredLength = 4;
		            options.Password.RequireNonAlphanumeric = false;
		            options.Password.RequireUppercase = false;
		            options.Password.RequireLowercase = false;
                }).AddPasswordValidator<CustomPasswordValidator>()
                .AddUserValidator<CustomUserValidator>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddErrorDescriber<CustomIdentityErrorDescriber>();


                /*database working */      services.AddDbContextPool<ApplicationDbContext>( // replace "YourDbContext" with the class name of your DbContext
                options => options.UseMySql("Server=localhost;port=3306;Database=Pos;User=root;Password=1234;", // replace with your Connection String
                    mySqlOptions =>
                    {
                        mySqlOptions.ServerVersion(new Version(5, 7, 17), ServerType.MySql); // replace with your Server Version and Type
                    }
            ));


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
                 CookieBuilder cookieBuilder = new CookieBuilder();
                cookieBuilder.Name= "MyPos";
                cookieBuilder.HttpOnly= false;
                cookieBuilder.SameSite = SameSiteMode.Lax;
                cookieBuilder.SecurePolicy= CookieSecurePolicy.SameAsRequest;


                services.ConfigureApplicationCookie(opts => {
                    opts.LoginPath= new PathString("/Home/Login");
                    opts.Cookie= cookieBuilder;
                    opts.SlidingExpiration=true;
                    opts.ExpireTimeSpan=System.TimeSpan.FromDays(60);
                });


            services.AddMvc();
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
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

       

              app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Anasayfa}/{id?}");
            });
        }
    }

    internal class CustomPasswordValidator<T>
    {
    }
}

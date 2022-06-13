using DuHoc.Email;
using DuHoc.Models;
using DuHoc.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DuHoc
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
            services.AddOptions();
            var mailsettings = Configuration.GetSection("MailSettings");
            services.Configure<MailSettings>(mailsettings);


            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<DuHocContext>(options =>
             options.UseSqlServer(
                 Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
               .AddEntityFrameworkStores<ApplicationDbContext>()
               .AddDefaultTokenProviders();

            services.AddTransient<IStorageService, FileStorageService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<INewsService, NewsService>();
            services.AddTransient<ICommonCategoryService, CommonCategoryService>();
            services.AddTransient<IQuestionService, QuestionService>();
            services.AddTransient<INewsCategoryService, NewsCategoryService>();
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<IRankService, RankService>();
            services.AddTransient<ISchoolService, SchoolService>();
            services.AddTransient<ISlideService, SlideService>();
            services.AddTransient<IFeedbackService, FeedbackService>(); 
            services.AddTransient<ISendMailService, SendMailService>();
            services.AddControllersWithViews();
            IMvcBuilder builder = services.AddRazorPages();
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

#if DEBUG
            if (environment == Environments.Development)
            {
                builder.AddRazorRuntimeCompilation();
            }
#endif

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(100);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddControllersWithViews();
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

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
               endpoints.MapControllerRoute(
               name: "SearchAdvand",
               pattern: "tim-kiem-chi-tiet", new
               {
                   controller = "Schools",
                   action = "SearchAdvand"
               });

                endpoints.MapControllerRoute(
               name: "Search",
               pattern: "tim-kiem", new
               {
                   controller = "Schools",
                   action = "Search"
               });

                endpoints.MapControllerRoute(
                name: "Blog",
                pattern: "tin-tuc", new
                {
                    controller = "New",
                    action = "Index"
                });

                endpoints.MapControllerRoute(
                name: "Blog Detail",
                pattern: "tin-tuc/chi-tiet/{url}/{id}", new
                {
                    controller = "New",
                    action = "Detail"
                });

               endpoints.MapControllerRoute(
               name: "Blog by category",
               pattern: "tin-tuc/{url}/{id}", new
               {
                   controller = "New",
                   action = "Category"
               });

                endpoints.MapControllerRoute(
                 name: "School Category",
                 pattern: "{url}/{id}", new
                 {
                     controller = "School",
                     action = "Category"
                 });

                endpoints.MapControllerRoute(
                 name: "School Detail",
                 pattern: "truong-hoc/{url}/{id}", new
                 {
                     controller = "School",
                     action = "Detail"
                 });

                endpoints.MapControllerRoute(
                 name: "Question Category",
                 pattern: "cau-hoi/{url}/{id}", new
                 {
                     controller = "Question",
                     action = "Category"
                 });

                endpoints.MapControllerRoute(
                 name: "Question Detail",
                 pattern: "cau-hoi/chi-tiet/{url}/{id}", new
                 {
                     controller = "Question",
                     action = "Detail"
                 });

                endpoints.MapControllerRoute(
                 name: "contact",
                 pattern: "lien-he", new
                 {
                     controller = "Home",
                     action = "Contact"
                 });

                endpoints.MapControllerRoute(
                name: "contact",
                pattern: "gioi-thieu", new
                {
                    controller = "Home",
                    action = "About"
                });


                endpoints.MapControllerRoute(
                 name: "du hoc nhat",
                 pattern: "du-hoc-nhat-ban", new
                 {
                     controller = "Home",
                     action = "DuHocNhatBan"
                 });

                endpoints.MapControllerRoute(
                 name: "du hoc han",
                 pattern: "du-hoc-han-quoc", new
                 {
                     controller = "Home",
                     action = "DuHocHanQuoc"
                 });

                endpoints.MapControllerRoute(
                name: "admin",
                pattern: "admin", new
                {
                    area = "Admin",
                    controller = "Account",
                    action = "Login"
                });

                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


                endpoints.MapRazorPages();
            });
        }
    }
}

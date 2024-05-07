using RemoteWorkProductivityTracker.Models.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using RemoteWorkProductivityTracker.Areas.Identity.Data;

namespace RemoteWorkProductivityTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'WorkTrackerContextConnection' not found.");

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddDbContext<WorkTrackerContext>();
            builder.Services.AddDbContext<TrackerDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<TrackerDbContext>();

            //Google Authentification
            builder.Services.AddAuthentication()
                .AddGoogle(options =>
            {
                options.ClientId = "707425327681-q5bnkst9qb96hgu7r4heud7jk5fuepgg.apps.googleusercontent.com";
                options.ClientSecret = "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";
            });

            builder.Services.AddRazorPages();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseAuthentication();
            app.MapRazorPages();

            app.Run();
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication3.Services;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Додавання сервісів
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<BookService>();
            builder.Services.AddSingleton<UserProfileService>();

            var app = builder.Build();

            // Налаштування маршрутизації
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Library/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "library",
                pattern: "Library/{action=Index}/{id?}",
                defaults: new { controller = "Library" });

            app.Run();
        }
    }
}


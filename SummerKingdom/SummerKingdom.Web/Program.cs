
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Data;

namespace SummerKingdom.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {

                string connectionString = @"Server=DESKTOP-C2DTSUG\SQLEXPRESS;Database=SummerKingdom;Trusted_Connection=True;";

                options.UseSqlServer(connectionString);
                options.EnableSensitiveDataLogging();
            });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Http Session
            builder.Services.AddSession(options =>
            {
                // With IdleTimeout you can change the number of seconds after which the session expires.
                // The seconds reset every time you access the session.
                // This only applies to the session, not the cookie.
                options.IdleTimeout = TimeSpan.FromSeconds(600);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });



            var app = builder.Build();

            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseSession();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "SummerKingdom API V1");
                options.RoutePrefix = "api/swagger";
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();

            // Enables the views to use resources from wwwroot
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            app.MapControllers();

            app.Run();
        }
    }
}
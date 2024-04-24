using Biluthyrning.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Biluthyrning.Interface;
using Biluthyrning.Repositorys;
using Biluthyrning.ViewModels;
using System.Text;
using System.Net.Http.Headers;

namespace Biluthyrning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddTransient<IVehicleRepository, VehicleRepository>();
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddTransient<IVehicleTypeRepository, VehicleTypeRepository>();
            builder.Services.AddTransient<IBookingRepository, BookingRepository>();

            builder.Services.AddHttpClient();

            HttpClient client = new HttpClient();


            builder.Services.AddHttpClient();


            builder.Services.AddScoped(sp =>
            {
            {
                var client = new HttpClient

                { BaseAddress = new Uri("https://localhost:7106/") };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImpvaGFuIiwic3ViIjoiam9oYW4iLCJqdGkiOiIxOGNmZjcwMCIsImF1ZCI6WyJodHRwOi8vbG9jYWxob3N0OjI5NjM5IiwiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzOTMiLCJodHRwOi8vbG9jYWxob3N0OjUyNTIiLCJodHRwczovL2xvY2FsaG9zdDo3MTA2Il0sIm5iZiI6MTY4MzUzOTM3NywiZXhwIjoxNjkxNDg4MTc3LCJpYXQiOjE2ODM1MzkzNzgsImlzcyI6ImRvdG5ldC11c2VyLWp3dHMifQ.Pn7oCzW3Pc6Zorin4IZr2xZApE2w_6YM2SP4S-xkMq4");
                return client;
              }
            });


            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");
            app.Run();
        }
    }
}



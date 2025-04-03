using Data;
using DTO;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using PharmaceuticalManagement_BuiManhCuong.Hubs;
using Repository;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

byte[] secretBytes = new byte[64];

using (var rng = RandomNumberGenerator.Create())
{
    rng.GetBytes(secretBytes);
}

string secretKey = Convert.ToBase64String(secretBytes);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<Sp25PharmaceuticalDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBDefault")));

//depen
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IMedicineRepository, MedicineRepository>();
builder.Services.AddScoped<IManufacturerRepository, ManufacturerRepository>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Accounts/Login";
                options.AccessDeniedPath = "/Accounts/AccessDenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
            });

builder.Services.AddSignalR();

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

app.MapHub<MedicineHub>("/medicineHub");

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();

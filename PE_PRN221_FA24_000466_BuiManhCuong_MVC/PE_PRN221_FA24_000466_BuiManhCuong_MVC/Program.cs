using Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using PE_PRN221_FA24_000466_BuiManhCuong_MVC.Hubs;
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
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Sp25PharmaceuticalDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//depen
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IMedicineRepository, MedicineRepository>();
builder.Services.AddScoped<IManufacturerRepository, ManufacturerRepository>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Auth/Login";
                options.AccessDeniedPath = "/Home/AccessDenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
            });

builder.Services.AddSignalR();

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

app.MapHub<MedicineHub>("/medicineHub");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

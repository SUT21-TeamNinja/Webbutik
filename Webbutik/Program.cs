using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Webbutik.Controllers;
using Webbutik.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddDefaultUI()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
builder.Services.AddScoped(c => CartController.GetCart(c));

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
//});

//sessions for shoppingcart
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();


var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBMAY9C3t2VVhjQlFac19JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0VhUX9XdXRXTmNeU0M=");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();
app.UseAuthentication(); ;

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

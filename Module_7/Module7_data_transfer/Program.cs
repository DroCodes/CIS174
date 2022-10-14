using Microsoft.EntityFrameworkCore;
using Module7_data_transfer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddNewtonsoftJson();

builder.Services.AddDbContext<CountryContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("CountryContext")));

builder.Services.AddMemoryCache();
builder.Services.AddSession(
     options =>
{
    // sets timeout to 5 minutes from default of 20 minutes
    options.IdleTimeout = TimeSpan.FromSeconds(60 * 5);
    options.Cookie.HttpOnly = false;
    options.Cookie.IsEssential = true;
});

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

app.UseSession();

app.MapControllerRoute(
    name: "custom",
    pattern: "{controller}/{action}/game/{activeGame}/cat/{activeCat}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

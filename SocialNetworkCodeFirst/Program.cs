using Microsoft.EntityFrameworkCore;
using SocialNetworkCodeFirst.Data;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
builder.Services.AddDbContext<SocialNetworkDbContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("Default"))
);

// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

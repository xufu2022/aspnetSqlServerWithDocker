using AspNetSqlDocker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionstring = "Server=sqldata;Database=FilmDB;User ID=sa;Password=2Secure*Password2 ";
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FilmContext>(filmOpt =>
    filmOpt.UseSqlServer(connectionstring, options=>options.MigrationsAssembly("AspNetSqlDocker")));

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
    pattern: "{controller=Film}/{action=Index}/{id?}");

app.Run();

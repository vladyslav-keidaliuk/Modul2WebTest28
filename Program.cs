using Microsoft.EntityFrameworkCore;
using Modul2WebTest28.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EFDatabaseContext>(db => db.UseMySQL(
    builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<EFDatabaseContext>();
builder.Services.AddScoped<IDataRepository,EFDatabaseRepository>();


var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

app.MapControllerRoute(
    name:"Default",
    pattern:"{controller=Home}/{action=Index}"
    );

app.Run();

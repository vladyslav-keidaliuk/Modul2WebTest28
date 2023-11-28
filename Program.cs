var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

app.MapControllerRoute(
    name:"Default",
    pattern:"{controller=Home}/{action=Index}"
    );

app.Run();

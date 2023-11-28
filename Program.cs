using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options => 
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
    b => b.MigrationsAssembly("StoreApp"));
});

var app = builder.Build();

// Statik dosyaların kullanılacağı ifade edilir. wwwroot dizini kullanılır anlamına gelir.
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () => "Welcome to test page!");
app.Run();

using Prevdent.Application.Interfaces;
using Prevdent.Infraestructure.Data.Repositories;
using Prevdent.Infraestructure.Data.AppData;
using Prevdent.Application.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
});

builder.Services.AddTransient<IDentistaRepository, DentistaRepository>();

builder.Services.AddScoped<IDentistaApplicationService, DentistaApplicationService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

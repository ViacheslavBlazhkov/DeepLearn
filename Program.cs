using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DeepLearn.Data;
using DeepLearn.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DeepLearnContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DeepLearnContext") ?? throw new InvalidOperationException("Connection string 'DeepLearnContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedDataModules.Initialize(services);
    SeedDataLessons.Initialize(services);
    // SeedDataThoryBlocks.Initialize(services); TODO: need to seed
}

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

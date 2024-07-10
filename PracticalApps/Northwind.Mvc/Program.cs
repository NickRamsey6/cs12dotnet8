#region Import namespaces
using Northwind.EntityModels; // To use AddNorthwindContext method
using Microsoft.AspNetCore.Identity; // To use IdentityUser
using Microsoft.EntityFrameworkCore; // To use UseSqlServer method
using Northwind.Mvc.Data; // To use ApplicationDbContext
#endregion

#region Configure the host web server including services
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register the application database context using SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add ASP.NET Core Identity for authenticatin and configure it to use the application database
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add support for MVC controllers with views
builder.Services.AddControllersWithViews();

builder.Services.AddNorthwindContext();

var app = builder.Build();

#endregion

#region Configure the HTTP request pipeline
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

#endregion

#region Start the host web server listening for HTTP requests
app.Run(); // This is a blocking call

#endregion
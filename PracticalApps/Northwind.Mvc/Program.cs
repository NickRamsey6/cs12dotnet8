#region Import namespaces
using Northwind.EntityModels; // To use AddNorthwindContext method
using Microsoft.AspNetCore.Identity; // To use IdentityUser
using Microsoft.EntityFrameworkCore; // To use UseSqlServer method
using Northwind.Mvc.Data; // To use ApplicationDbContext
using System.Net.Http.Headers; // To use MediaTypeWithQualityHeaderValue
using System.Net; // To use HttpVersion
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

// Add output cache middleware and override the default expiration timespan
builder.Services.AddOutputCache(options =>
{
    options.DefaultExpirationTimeSpan = TimeSpan.FromSeconds(20);
    options.AddPolicy("views", p => p.SetVaryByQuery("alertstyle"));
});

builder.Services.AddHttpClient(name: "Northwind.WebApi", configureClient: options =>
{
    options.BaseAddress = new Uri("https://localhost:5151/");
    options.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue(
            mediaType: "application/json", quality: 1.0));
});

// DOES NOT WORK
//builder.Services.AddHealthChecks()
//  .AddCheck()
//  // Execute SELECT 1 using the specified connection string.
//  .AddSqlServer("Data Source=.;Initial Catalog=Northwind;Integrated Security=true;TrustServerCertificate=true;");

builder.Services.AddHttpClient(name: "Northwind.WebApi",
    configureClient: options =>
    {
        options.DefaultRequestVersion = HttpVersion.Version30;
        options.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionOrLower;

        options.BaseAddress = new Uri("https://localhost:5151/");
        options.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue(
                mediaType: "application/json", quality: 1.0));
    });

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

// Use output cache
app.UseOutputCache();

// DOES NOT WORK
//app.UseHealthChecks(path: "/howdoyoufell");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    //.CacheOutput(policyName: "views");
app.MapRazorPages();

// Create two endpoints that respond with plain text (one not cached, the other cached)
app.MapGet("/notcached", () => DateTime.Now.ToString());
app.MapGet("/cached", () => DateTime.Now.ToString()).CacheOutput();
#endregion

#region Start the host web server listening for HTTP requests
app.Run(); // This is a blocking call

#endregion
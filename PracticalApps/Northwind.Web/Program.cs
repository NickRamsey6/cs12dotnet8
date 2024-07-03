using Northwind.EntityModels; // To use AddNorthwindContext method

#region Configure the web server host and services

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddNorthwindContext();

var app = builder.Build();

#endregion

#region

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseDefaultFiles(); // index.html, default.html and so on
app.UseStaticFiles();

app.MapRazorPages();
app.MapGet("/hello", () => 
    $"Environment is {app.Environment.EnvironmentName}");

#endregion


// Start the web server, host the website, and wait for requests.
app.Run(); // This ia a thread-blocking call
WriteLine("This executes after the web server has stopped!");

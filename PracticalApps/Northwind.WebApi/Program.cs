using Microsoft.AspNetCore.Mvc.Formatters; // To use IOutputFormatter
using Northwind.EntityModels; // To use AddNorthwindContext method
using Microsoft.Extensions.Caching.Memory; // To use IMemoryCache and so on

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Register an implementation for the in-memory cache as a singleton instance that is constructed immediately
builder.Services.AddSingleton<IMemoryCache>(
    new MemoryCache(new MemoryCacheOptions()));

// Register the Northwind database context class
builder.Services.AddNorthwindContext();

builder.Services.AddControllers(options =>
{
    // Writing the names and supported media types of the default output formatters to the console
    WriteLine("Default output formatters:");
    foreach (IOutputFormatter formatter in options.OutputFormatters)
    {
        OutputFormatter? mediaFormatter = formatter as OutputFormatter;
        if (mediaFormatter is null)
        {
            WriteLine($" {formatter.GetType().Name}");
        }
        else // OutputFormatter class has SupportedMediaTypes
        {
            WriteLine(" {0}, Media types: {1}",
                arg0: mediaFormatter.GetType().Name,
                arg1: string.Join(", ",
                    mediaFormatter.SupportedMediaTypes));
        }
    }
})
    .AddXmlDataContractSerializerFormatters()
    .AddXmlSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

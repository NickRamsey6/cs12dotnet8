using Microsoft.AspNetCore.Mvc.Formatters; // To use IOutputFormatter
using Northwind.EntityModels; // To use AddNorthwindContext method
using Microsoft.Extensions.Caching.Memory; // To use IMemoryCache and so on
using Northwind.WebApi.Repositories; // To use ICustomerRepository
using Swashbuckle.AspNetCore.SwaggerUI; // To use SubmitMethod
using Microsoft.AspNetCore.HttpLogging; // To use HttpLoggingFields

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All;
    options.RequestBodyLogLimit = 4096; // Default is 32k
    options.ResponseBodyLogLimit = 4096; // Default is 32k
});

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

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

var app = builder.Build();
app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json",
            "Northwind Service API Version 1");

        c.SupportedSubmitMethods(new[]
        {
            SubmitMethod.Get, SubmitMethod.Post,
            SubmitMethod.Put, SubmitMethod.Delete });
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<SecurityHeaders>();

app.MapControllers();

app.Run();

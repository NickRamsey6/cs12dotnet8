using Microsoft.AspNetCore.Mvc;

namespace Northwind.WebApi.Controllers
{
    // [ApiController] enables REST-specific behavior for controllers
    [ApiController]
    // Route attribute registers the /weatherforecast relative URL for clients to make HTTP requests that will be handled by this controller
    // Uses the characters before Controller in the class name i.e. WeatherForecast
    [Route("[controller]")]
    // Controller class inherits from ControllerBase
    // This is simpler than Controller class in MVC
    // Does not have methods like View to generate HTML responses
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // HttpGet registers the Get method in the controller class to respond to HTTP GET requests
        // GET /weatherforecast
        [HttpGet(Name = "GetWeatherForecastFiveDays")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Get(days: 5); // Five-day forecast
        }

        // GET /weatherforecast/7
        [HttpGet(template: "{days:int}", Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get(int days)
        {
            return Enumerable.Range(1, days).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

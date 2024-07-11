using Microsoft.AspNetCore.Mvc; // To use Controller, IActionResult
using Northwind.Mvc.Models; // To use ErrorViewModel
using System.Diagnostics; // To use Activity
using Northwind.EntityModels; // To use NorthwindContext
using Microsoft.EntityFrameworkCore; // To use Include method

namespace Northwind.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext _db;

        public HomeController(ILogger<HomeController> logger, NorthwindContext db)
        {
            _logger = logger;
            _db = db;
        }

        [ResponseCache(Duration = 10 /* seconds */,
            Location = ResponseCacheLocation.Any)]
        public IActionResult Index()
        {
            _logger.LogError("This is a serious error (not really!)");
            _logger.LogWarning("This is your first warning!");
            _logger.LogWarning("Second warning!");
            _logger.LogInformation("I am in the index method of the HomeController.");

            HomeIndexViewModel model = new(
                VisitorCount: Random.Shared.Next(1, 1001),
                Categories: _db.Categories.ToList(),
                Products: _db.Products.ToList()
            );

            return View(model); // Pass the model to the view
        }

        [Route("private")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ProductDetail(int? id, string alertstyle = "success")
        {
            ViewData["alertstyle"] = alertstyle;
            if (!id.HasValue)
            {
                return BadRequest("You must pass a product ID in the route, for example, /Home/ProductDetail/21");
            }

            Product? model = _db.Products.Include(p => p.Category)
                .SingleOrDefault(p => p.ProductId == id);

            if (model is null)
            {
                // NotFound method allows a custom message for 404 status codes
                return NotFound($"ProductId {id} not found.");
            }

            return View(model); // Pass model to view and then return result
        }

        // This action method will handle GET and other requests except POST
        public IActionResult ModelBinding()
        {
            return View(); // The page with a form to submit
        }

        [HttpPost] // This action method will handle POST requests
        public IActionResult ModelBinding(Thing thing)
        {
            HomeModelBindingViewModel model = new(
                Thing: thing, HasErrors: !ModelState.IsValid,
                ValidationErrors: ModelState.Values
                    .SelectMany(state => state.Errors)
                    .Select(error => error.ErrorMessage)
            );

            return View(model); // Show the model bound thing
        }
    }
}

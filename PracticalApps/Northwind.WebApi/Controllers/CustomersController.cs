// To use [Route], [ApiController], ControllerBase and so on
using Microsoft.AspNetCore.Mvc;
using Northwind.EntityModels; // To use Customer
using Northwind.WebApi.Repositories; // To use ICustomerRepository

namespace Northwind.WebApi.Controllers;

// Base address: api/customers
[Route("api/[controller]")]
// The Controller class registers a route using the [Route] attribute that starts with api/ and includes the name of the controller
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerRepository _repo;

    // Constructor injects repoistory registered in program.cs
    public CustomersController(ICustomerRepository repo)
    {
        _repo = repo;
    }

    // GET: api/customers
    // GET: api/customers/?country=[country]
    // this will always return a list of customers (but it might be empty)
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
    public async Task<IEnumerable<Customer>> GetCustomers(string? country)
    {
        if (string.IsNullOrWhiteSpace(country))
        {
            return await _repo.RetrieveAllAsync();
        }
        else
        {
            return (await _repo.RetrieveAllAsync())
                .Where(customer => customer.Country == country);
        }
    }

    // GET: api/customers/[id]
    [HttpGet("{id}", Name = nameof(GetCustomer))] // Named route
    // Use a route explicitly named GetCustomer so it can be used to generate a URL after inserting a new customer
    [ProducesResponseType(200, Type = typeof(Customer))]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetCustomer(string id)
    {
        Customer? c = await _repo.RetrieveAsync(id);
        if (c == null)
        {
            return NotFound(); // 404 Resource not found
        }
        return Ok(c); // 200 OK with customer in body
    }

    // POST: api/customers
    // BODY: Customer (JSON, XML)
    [HttpPost]
    [ProducesResponseType(201, Type = typeof(Customer))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] Customer c)
    // Decorate the customer parameter with [FromBody] to tell the model binder to populate it with values from the body of the POST request
    {
        if (c == null)
        {
            return BadRequest(); // 400 Bad Request
        }
        Customer? addedCustomer = await _repo.CreateAsync(c);
        if (addedCustomer == null)
        {
            return BadRequest("Repository failed to create customer.");
        }
        else
        {
            // Create method returns a response that uses GetCustomer route so that the client knows how to get the newly created resource in the future
            return CreatedAtRoute( // 201 Created
                routeName: nameof(GetCustomer),
                routeValues: new { id = addedCustomer.CustomerId.ToLower() },
                value: addedCustomer);
        }
    }

    // PUT: api/customers/[id]
    // Body: ustomer (JSON, XML)
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update(string id, [FromBody] Customer c)
    // Decorate the customer parameter with [FromBody] to tell the model binder to populate it with values from the body of the POST request
    {
        id = id.ToUpper();
        c.CustomerId = c.CustomerId.ToUpper();
        if (c == null || c.CustomerId != id)
        {
            return BadRequest(); // 400 Bad request
        }
        Customer? existing = await _repo.RetrieveAsync(id);
        if (existing == null)
        {
            return NotFound(); // 404 Resource not found
        }
        await _repo.UpdateAsync(c);
        return new NoContentResult(); // 204 No content
    }

    // DELETE: api/customers/[id]
    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(string id)
    {
        // Take control of problem details
        if (id == "bad")
        {
            ProblemDetails problemDetails = new()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "https://localhost:5151/customers/failed-to-delete",
                Title = $"Customer ID {id} found but failed to delete.",
                Detail = "More details like Company Name, Country and so on.",
                Instance = HttpContext.Request.Path
            };
            return BadRequest(problemDetails); // 400 Bad request
        }
        Customer? existing = await _repo.RetrieveAsync(id);
        if (existing == null)
        {
            return NotFound(); // 404 Resource not found
        }
        bool? deleted = await _repo.DeleteAsync(id);
        if (deleted.HasValue && deleted.Value) // Short circuit AND.
        {
            return new NoContentResult(); // 204 No content
        }
        else
        {
            return BadRequest( // 400 Bad request
              $"Customer {id} was found but failed to delete.");
        }
    }
}



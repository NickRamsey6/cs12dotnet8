using Microsoft.AspNetCore.Mvc; // To use [BindProperty], IActionResult 
using Northwind.EntityModels; // To use NorthwindContext
using Microsoft.AspNetCore.Mvc.RazorPages; // To use PageModel

namespace Northwind.Web.Pages;

public class SuppliersModel : PageModel
{
    public IEnumerable<Supplier>? Suppliers { get; set; }

    [BindProperty]
    public Supplier? Supplier { get; set; }

    public IActionResult OnPost()
    {
        if (Supplier is not null && ModelState.IsValid)
        {
            _db.Suppliers.Add(Supplier);
            _db.SaveChanges();
            return RedirectToPage("/suppliers");
        }
        else
        {
            return Page(); // Redirect to original page
        }
    }

    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Suppliers";

        Suppliers = _db.Suppliers
            .OrderBy(c => c.Country)
            .ThenBy(c => c.CompanyName);
    }

    // Private field to store Northwind database context
    private NorthwindContext _db;

    // Constructor to set db context
    public SuppliersModel(NorthwindContext db)
    {
    _db = db;
    }
}

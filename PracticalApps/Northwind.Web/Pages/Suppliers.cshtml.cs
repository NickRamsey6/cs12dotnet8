using Northwind.EntityModels; // To use NorthwindContext
using Microsoft.AspNetCore.Mvc.RazorPages; // To use PageModeL

namespace Northwind.Web.Pages;

public class SuppliersModel : PageModel
{
    public IEnumerable<Supplier>? Suppliers { get; set; }

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

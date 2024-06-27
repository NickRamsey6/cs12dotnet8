using Microsoft.EntityFrameworkCore; // To use Include method
using Northwind.EntityModels; // To use Northwind, Category, Product

partial class Program
{
    private static void QueryingCategories()
    {
        using NorthwindDb db = new();

        SectionTitle("Categories and how many products they have");

        // A query to get all categories and their related products
        IQueryable<Category>? categories = db.Categories?.Include(c => c.Products);

        if (categories is null || !categories.Any())
        {
            Fail("No categories found.");
            return;
        }

        // Execute query and enumerate results
        foreach (Category c in  categories)
        {
            WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
        }
    }
}

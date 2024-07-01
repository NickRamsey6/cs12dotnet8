using Northwind.EntityModels; // To use NorthwindDb, Category, Product
using Microsoft.EntityFrameworkCore; // To use DbSet<T>

partial class Program
{
    private static void FilterAndSort()
    {
        SectionTitle("Filter and sort");

        using NorthwindDb db = new();

        DbSet<Product> allProducts = db.Products;

        IQueryable<Product> filteredProducts = allProducts.Where(product => product.UnitPrice < 10M);

        IOrderedQueryable<Product> sortedAndFilteredProducts = filteredProducts.OrderByDescending(product => product.UnitPrice);

        // Extend LINQ query to use the Select method to return only three properties that we need
        var projectedProducts = sortedAndFilteredProducts
            .Select(product => new // Anonymous type
            {
                product.ProductId,
                product.ProductName,
                product.UnitPrice
            });

        WriteLine("Products that cost less than $10:");

        //Output the SQL
        WriteLine(projectedProducts.ToQueryString());
        //foreach (Product p in sortedAndFilteredProducts)
        foreach (var p in projectedProducts)
        {
            WriteLine("{0}: {1} costs {2:$#, ##0.00}",
                p.ProductId, p.ProductName, p.UnitPrice);
        }
        WriteLine();
    }
}
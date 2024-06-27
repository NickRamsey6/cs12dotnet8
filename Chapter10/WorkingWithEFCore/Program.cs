using Northwind.EntityModels; // To use Northwind

//using NorthwindDb db = new();
//WriteLine($"Provider: {db.Database.ProviderName}");
// Disposes the database context

//ConfigureConsole();
//QueryingCategories();
//FilteredIncludes();
//QueryingProducts();
//GettingOneProduct();
//QueryingWithLike();
//GetRandomProduct();

//LazyLoadingWithNoTracking();

var resultAdd = AddProduct(categoryId: 6,
    productName: "Bob's Burgers", price: 500M, stock: 72);

if (resultAdd.affected == 1)
{
    WriteLine($"Add product successful with ID: {resultAdd.productId}.");
}

ListProducts(productIdsToHighlight: new[] { resultAdd.productId });
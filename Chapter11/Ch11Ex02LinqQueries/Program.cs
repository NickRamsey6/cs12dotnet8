using Northwind.EntityModels;

using NorthwindDb db = new();

Write("Enter the name of a city: ");
string inputCity = ReadLine()!;
WriteLine();


IQueryable<Customer> customersInCity = db.Customers.Where(c => c.City == inputCity);

if ((customersInCity is null) || (!customersInCity.Any()))
{
    WriteLine($"No customers found in {inputCity}.");
    return;
}

WriteLine($"There are {customersInCity.Count()} customers in {inputCity}:");
foreach (Customer c in customersInCity)
{
    WriteLine($"  {c.CompanyName}");
}
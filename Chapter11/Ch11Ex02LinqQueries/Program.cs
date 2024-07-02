using Northwind.EntityModels;

using NorthwindDb db = new();

IQueryable<string> distinctCities = db.Customers.Select(c => c.City).Distinct()!;

WriteLine($"We do business in {distinctCities.Count()} cities.");
WriteLine("Here are all the cities we do business in:");
foreach (string city in distinctCities)
{
    WriteLine(city);
}

Write("Enter the name of a city to filter on: ");
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
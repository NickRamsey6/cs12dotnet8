using Microsoft.EntityFrameworkCore.ChangeTracking; // To use EntityEntry<T>.
using Northwind.EntityModels; // To use Customer.
using Microsoft.Extensions.Caching.Memory; // To use IMemoryCache.
using Microsoft.EntityFrameworkCore; // To use ToArrayAsync.

namespace Northwind.WebApi.Repositories;

// This class implements the ICustomerRepository interface
public class CustomerRepository : ICustomerRepository
{
    private readonly IMemoryCache _memoryCache;

    // Use the singleton in-memory cache with a 30 minute sliding expiration for its cache entires
    private readonly MemoryCacheEntryOptions _cacheEntryOptions = new()
    {
        SlidingExpiration = TimeSpan.FromMinutes(30)
    };

    // Use an instance data context field because it should not be
    // cached due to the data context having internal caching.
    private NorthwindContext _db;

    public CustomerRepository(NorthwindContext db,
            IMemoryCache memoryCache)
    {
        _db = db;
        _memoryCache = memoryCache;
    }


    // Implement the create method
    public async Task<Customer?> CreateAsync(Customer c)
    {
        c.CustomerId = c.CustomerId.ToUpper(); // Normalize to uppercase.

        // Add to database using EF Core.
        EntityEntry<Customer> added = await _db.Customers.AddAsync(c);
        int affected = await _db.SaveChangesAsync();
        if (affected == 1)
        {
            // If saved to database then store in cache.
            _memoryCache.Set(c.CustomerId, c, _cacheEntryOptions);
            return c;
        }
        return null;
    }

    // Implement the retrieve all method to always read the latest customers from the database
    public Task<Customer[]> RetrieveAllAsync()
    {
        return _db.Customers.ToArrayAsync();
    }

    // Implement the retrieve method to use in-memory cache if possible
    public Task<Customer?> RetrieveAsync(string id)
    {
        id = id.ToUpper(); // Normalize to uppercase

        // Try to get from the cache first
        if (_memoryCache.TryGetValue(id, out Customer? fromCache))
            return Task.FromResult(fromCache);

        // If not in the cache, then try to get it from the database
        Customer? fromDb = _db.Customers.FirstOrDefault(c => c.CustomerId == id);

        // If not -in database then return null result
        if (fromDb is null) return Task.FromResult(fromDb);

        // If in the database, then store in the cache and return customer
        _memoryCache.Set(fromDb.CustomerId, fromDb, _cacheEntryOptions);
        return Task.FromResult(fromDb)!;
    }

    // Implement the update method to update the database and if successful then update the cached customer as well
    public async Task<Customer?> UpdateAsync(Customer c)
    {
        c.CustomerId = c.CustomerId.ToUpper();

        _db.Customers.Update(c);
        int affected = await _db.SaveChangesAsync();
        if (affected == 1)
        {
            _memoryCache.Set(c.CustomerId, c, _cacheEntryOptions);
            return c;
        }
        return null;
    }

    // Implement the delete method to delete the customer from the database and if successful then remove the cached customer as well
    public async Task<bool?> DeleteAsync(string id)
    {
        id = id.ToUpper();

        Customer? c = await _db.Customers.FindAsync(id);
        if (c is null) return null;

        _db.Customers.Remove(c);
        int affected = await _db.SaveChangesAsync();
        if (affected == 1)
        {
            _memoryCache.Remove(c.CustomerId);
            return true;
        }
        return null;
    }
}
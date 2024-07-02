using Microsoft.Data.SqlClient; // To use SqlConnectionStringBuilder
using Microsoft.EntityFrameworkCore; // To use DbContext, DbSet<T>

namespace Northwind.EntityModels;

public class NorthwindDb : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        #region to use SqLite

        string database = "Northwind.db";
        string dir = Environment.CurrentDirectory;
        string path = string.Empty;

        // The database file will stay in the project folder
        // We will automatically adjust the relative path to
        // account for running in VS2022 or from the terminal

        if (dir.EndsWith("net8.0"))
        {
            // Running in the <project>\bin\<Debug/Release>\net8.0 directory
            path = Path.Combine("..", "..", "..", database);
        }
        else
        {
            // Running in the <project> directory
            path = database;
        }

        path = Path.GetFullPath(path); // Convert to absolute path
        WriteLine($"SQLite database path: {path}");

        if (!File.Exists(path))
        {
            throw new FileNotFoundException(
                message: $"{path} not found.");
        }

        // To use SQLite
        optionsBuilder.UseSqlite($"Data Source={path}");

        #endregion
    }
}
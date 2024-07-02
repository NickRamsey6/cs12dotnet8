// To use [Required] and [StringLength].
using System.ComponentModel.DataAnnotations;

namespace Northwind.EntityModels;

public class Customer
{
    [StringLength(5)]
    public string CustomerId { get; set; } = null!;

    [Required]
    [StringLength(40)]
    public string CompanyName { get; set; } = null!;

    [StringLength(15)]
    public string? City { get; set; }
}

# Chapter 10 Working with Data Using Entity Framework Core

## Key Concepts

## EF Core Annotation Attributes
| Attribute | Description |
|-----------|-------------|
| [Required] | Ensures the value is not null. In .NET 8, it has a DisallowAllDefaultValues parameter to prevent value types having their default value. For example, an int cannot be 0. |
| [StringLength(50)] | Ensures value is up to 50 characters in length. |
| [Column(TypeName = "money", Name = "UnitPrice")] | Specifies the column type and column name used iin the table. |

## Validation Annotation Attributes
| Attribute | Description |
|-----------|-------------|
| [RegularExpression(expression)] | Ensures the value matches the specified regular expression. |
| [EmailAddress] | Ensures the value contains one @ symbol, but not as the first or last character. It does not use a regular expression. |
| [Range(1, 10)] | Ensures a double, int, or string value within a specified range. New in .NET8 are the parameters MinimumExclusive and MaximumExclusive. |
| [Length(10, 20)] | Ensures a string or collection is within a specified length range, for example, minimum 10 characters or items, maximum 20 characters or items. |
| [Base64String] | Ensures the value is a well-formed Base64 string. |
| [AllowedValues] | Ensures value is one of he items in the params array of objects. For example, "alpha", "beta", "gamma", or 1, 2, 3. | 

## Projects List
* WorkingWithEFCore
* Northwind.EntityModels

## Practice Questions

## My takeaways / Questions / Notes
Do we just come up with namespace names?  
Do we use the scaffolding command or do we create our models manually?
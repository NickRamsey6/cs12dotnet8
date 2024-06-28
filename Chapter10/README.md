# Chapter 10 Working with Data Using Entity Framework Core

## Key Concepts
* Connect to and build entity data models for an existing database
* Execute a simple LINQ query and process the results
* Use Filtered Includes
* Control loading and tracking patterns
* Add, modify and delete data

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
* CoursesAndStudents - Code First EF Core Model

## Practice Questions
1. What type would you use for a property that represents a table, for example, the Products property of a database context?  
**Answer: DbSet<<T>T> where T is the entity type, in this example DbSet<<Product>Product>**
2. What type would you use for the property that represents a one-to-many relationship, for example, the Products property of a Category entity?  
**Answer: ICollection<T<T>> where T is the entity type, in this example ICollection<<Product>Product>**
3. What is the EF Core convention for primary keys?  
**Answer: ID or Id, or ClassNameID/ClassNameId**
4. When might you use an annotation attribute in an entity class?  
**Answer: When the type isnt an obvious map between .NET types and database types. Or if a class name does not match a table name, or a property name does not match a column name. You might also want to define constraints like field to be required or to set the max char length**
5. Why might you choose the Fluent API in preference to annotation attributes?  
**Answer: Fluent API keeps the model class simpler and can provide initial data to populate a database.**
6. What does a transaction isolation level of Serializable mean?  
**Answer: Maximum locks are applied to ensure complete isolation from any other processes working with the affected data.**
7. What does the Db.Context.SaveChanges() method return?  
**Answer: The number of entities affected as an INT.**
8. What is the difference between eager loading and explicit loading?  
**Answer: Eager loading means related entities are included in the original query to the database so that they do not have to be loaded later. Explicit loading means related entities are not included in the original query to the database, and must be explicitly loaded just before they are needed.**
9. How should you define an EF Core entity class to match the following table?  
```
CREATE TABLE Employees(
    EmpId INT IDENTITY,
    FirstName NVARCHAR(40) NOT NULL,
    Salary MONEY
)
```  
**Answer:**  
```
public class Emplyee
{
    [Column("EmpId")]
    public int EmployeeId { get; set; }

    [Required]
    [StringLength(40)]
    public string FirstName { get; set; }

    [Column(TypeName = "money")]
    public decimal? Salary { get; set; }
}
```
10. What benefit do you get from declaring entity navigation properties as virtual?  
**Answer: You can enable lazy loading on virtual entity navigation properties.**

## My takeaways / Questions / Notes
Do we just come up with namespace names?  
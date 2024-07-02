# Chapter 11 Querying and Manipulating Data Using LINQ

## Key Concepts

## LINQ Extension Methods
| Method(s) | Description |
|-----------|-------------|
| First, FirstOrDefault, Last, LastOrDefault | Get the first or last item in the sequence or throw an exception, or return the default value for the type, for example, 0 for an int and null for a reference type, if there is not a first or last item. |
| Where | Return a sequence of items that match a specified filter. |
| Single, SingleOrDefault | Return an item that matches a specific filter or throw an exception, or return the default value for the type if there is not exactly one match. |
| ElementAt, ElementAtOrDefault | Return an item at a specified index position or throw an exception, or return the default value for the type if there is not an item at that position. Introduced in .NET 6 are overloads that can be passed an Index instead of an int, which is more efficient when working with Span<T<T>> sequences. |
| Select, SelectMany | Project items into a different shape, that is, a different type, and flatten a nested hierarchy of items. |
| OrderBy, OrderByDescending, ThenBy, ThenByDescending | Sort items by a specified field or property. |
| Order, OrderDescending | Sort items by the item itself. |
| Reverse | Reverse the order of items. |
| GroupBy, GroupJoin, Join | Group and/or join two sequences. |
| Skip, SkipWhile | Skip a number of items; or skip when an expression is true. |
| Take, TakeWhile | Take a number of items, or take items while an expression is true, Introduced in .NET6 is an overload that can be passed a Range, for example, Take(range: 3..^5), meaning take a subset starting 3 items from the start and ending 5 items in from the end, or instead of Skip(4) you could use Take(4..). |
| Aggregate, Average, Count, LongCount, Max, Min, Sum | Calculate aggregate values. |
| TryGetNonEnumeratedCount | Count() checks if a Count property is implemented on the sequence and returns its value, or it enumerates the entire sequence to count its items. Introduced in .NET6 this method only checks for Count; if it is missing, it returns false and sets the out parameter to 0 to avoid a potentially poor-performing operation. |
| All, Any, Contains | Return true if all or any of the items match the filter, or if the sequence contains a specified item. |
| Cast<T<T>> | Cast items into a specified type. It is useful to convert non-generic objects into a generic type in scenarios where the compiler would otherwise complain. |
| OfType<T<T>> | Remove items that do not match a specified type. |
| Distinct | Remove duplicate items. |
| Except, Intersect, Union | Perform operations that return sets. Sets cannot have duplicate items. Although the inputs can be any sequence and so the inputs can have duplicates, the result is always a set. |
| DistinctBy, ExceptBy, IntersectBy, UnionBy, MinBy, MaxBy | Allow the comparison to be performed on a subset of the items rather than all the items. For example, instead of removing duplicates with Distinct by comparing an entire Person object, you could remove duplicates with DistinctBy by comparing just their LastName or DateOfBirth. |
| Chunk | Divide a sequence into sized batches. The size parameter specified the number of items in each chunk. The last chunk will contain the remaining items and could be less than size. |
| Append, Concat, Prepend | Perform sequence-combining operations. |
| Zip | Perform a match operation on two or three sequences based on the position of items, for example, the item at position 1 in the first sequence matches the item at position 1 in the second sequence. |
| ToArray, ToList, ToDictionary, ToHashSet, ToLookup | Convert the sequence into an array or collection. These are the only extension methods that force the execution of a LINQ expression immediately rather than wait for deferred execution. |

## Enumerable Non-Extension Methods
| Method | Description |
|--------|-------------|
| Empty<T<T>> | Returns an empty sequence of the specified type T. It is useful for passing an empty sequence to a method that requires an IEnumberable<T<T>>.
| Range | Returns a sequence of integers from the start value with count items. For example, Enumerable.Range(start: 5, count: 3) would contain the integers 5, 6 and 7. |
| Repeat | Returns a sequence that contains the same element repeated count times. For example, Enumerable.Repeat(element: "5", count: 3) would contain the string values "5", "5", and "5". |


## Projects List
* LinqWithObjects
* LinqWithEFCore
* Ch11Ex02LinqQueries

## Practice Questions
1. What are the two required parts of LINQ?  
**Answer: Extension Methods and LINQ Providers. Must also import System.LINQ namespace to make all LINQ extension methods available and reference a LINQ provider assembly for the type of data you are working with.**
2. Which LINQ extension method would you use to return a subset of properties from a type?  
**Answer: Select**
3. Which LINQ extension method would you use to filter a sequence?  
**Answer: Where**
4. List five LINQ extension methods that perform aggregation.  
**Answer: Aggregate, Sum, Average, Count, Max, Min**
5. What is the difference between Select and SelectMany extension methods?  
**Answer: Select returns exactly what you specify to return. SelectMany checks the items you have selected are IEnumerable and then breaks them down into smaller parts. With a string, SelectMany would break it down into its individual char values and combine them into a single sequence.**
6. What is the difference between IEnumerable<T<T>> and IQueryable<T<T>>? How do you switch between them?  
**Answer: IEnumerable indicates a LINQ provider that will execute the query locally like LINQ to Objects. IQueryable indicates a LINQ provider that first builds an expression tree to represent the query and then converts it into another query syntax before executing it.**
7. What does the last type parameter T in generic Func delegates like Func<T1, T2, T> represent?  
**Answer: Represents the type of the return value.**
8. What is the benefit of a LINQ extension method that ends with OrDefault?  
**Answer: OrDefault will return the default value for the type it was looking for if the method does not find what it was looking for. Example FirstOrDefault will return the default value for that type if there is no first value. This is useful for avoiding exceptions/runtime errors.**
9. Why is query comprehension syntax optional?  
**Answer: Because it is just syntactic sugar. Makes the code easier for humans to read.**
10. How can you create your own LINQ extension methods?  
**Answer: Create a static class with a static method, with an IEnumberable parameter prefixed with the ```this``` keyword.**

## Exercise 11.2 - Practice Querying With LINQ
1. File | Add > New Project > ConsoleApp Ch11Ex02LinqQueries
2. Copy Northwind4SQLite.sql script from main repo to Project directory
3. Run sql script to build Northwind db
5. In .csproj file: Import System.Console, EF Core and SQLite client and Build project
6. Create classes: NorthwindDb.cs and Customers.cs
7. Setup Customers.cs first





## My takeaways / Questions / Notes
Lambda Expression: is a nameless function.  => (goes to)

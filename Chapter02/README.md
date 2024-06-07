# Chapter 2 Summary

## Key Concepts
* Declare variables with specified or inferred types
* Use some of the built-in types for numbers, text, and booleans
* Choose between number types
* Control output formatting in console apps

## Number Types Examples
| Example | Type | Why |
| ------- | ---- | ----|
| Phone # | String| May include non numeric characters |
| Height | Float or Double| Probably wont need to run eqaulity or arthimetic operations|
| Age | Int| Best performance|
| Salary | Decimal| More precise for equality ops|
| Book ISBN | String| Non-numeric chars/ uuid|
| Price | Decimal| Most precise|
|Weight | Float or Double| See above|
| Population| UInt| UInt can go up to about 4billion|
| Total # of Stars in the Universe | ULong| ULong can go up to about 18quadrillion
| # of Employees for each business in USA | UShort| UShort only requires 2 bytes of memory|

## Practice Questions
1. What statement can you type in a C# file to discover the compiler and language version?  
**Answer: ```#error version```**
2. What are the two types of comments in C#?  
**Answer: single-line (//) and multi-line (/star star/ -Markdown doesnt like this)**
3. What is the difference between verbatim string and interpolated string?  
**Answer: verbatim (prefixed with @) and allows escape characters (\t). Interpolated (prefixed with $) enables embedded formatting**
4. Why should you be careful when using float and double values?  
**Answer: Floats and Doubles are not guranteed to be accurate when running equality comparisons - decimal is better here**
5. How can you determine howmany bytes a type like double uses in memory?  
**Answer: sizeof() operator - ```sizeof(double)```**
6. When should you use the var keyword?  
**Answer: Use var for declaring local variables that you are not specifying the type of**
7. What is the newest syntax to create an instance of a class like XmlDocument?  
**Answer: ```XmlDocument newXml = new()```**
8. Why should you be careful when using the dynamic type?  
**Answer: Dynamics have bad performance and the type of object is not checked until runtime which can lead to unexpected runtime exceptions**
9. How do you right-align a format string?  
**Answer: Add a positive integer value for the alignment  
```Console.WriteLine($"{sizeof(byte), 10}");```**
10. What character separates arguments for a console app?  
**Answer: space**

## Projects List
* Vocabulary - Practicing basic C# syntax
* Numbers - Learning differences between data types
* Variables - Storing values as objects, dynamics, and vars
* Formatting - Formatting outputs to the console
* Arguments - Passing in arguments
* AsyncConsole - Quick intro to Async/Await concepts
* Ch02Ex03Numbers - Practice number sizes and ranges


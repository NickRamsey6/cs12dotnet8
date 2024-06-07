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
**Answer: #error version**
2. What are the two types of comments in C#?  
**Answer: single-line (//) and multi-line (/star star/ Markdown doesnt like this)**
3. What is the difference between verbatim string and interpolated string?  
**Answer: verbatim (prefixed with @) and allows escape characters (\t). Interpolated (prefixed with $) enables embedded formatting**
4. Why should you be careful when using float and double values?  
**Answer:**

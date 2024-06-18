# Chapter 4 Summary

## Key Concepts
* How to write reusable functions with input parameters and return values, in both an imperative and functional style.
* How to use Visual Studio debugging and diagnostic features like logging and unit tests to identify and fix any bugs in them.
* How to throw and catch exceptions in functions and understand the call stack.

## Trace Levels
| Number | Word | Description |
| ------- | ---- | ----|
| 0 | Off | This will output nothing |
| 1 | Error | This will output only errors |
| 2 | Warning | This will output only warnings |
| 3 | Info | This will output errors, warnings and information |
| 4 | Verbose | This will output all levels |

## Attributes to get information about the method caller
| Parameter Example | Description |
| ------- | ----|
| [CallerMemberName] string member = "" | Sets the string parameter named *member* to the name of the method or property that is executing the method that defines this parameter. |
| [CallerFilePath] string filepath = "" | Sets the string parameter named *filepath* to the name of the source code file that contains the statement that is executing the method that defines this parameter. |
| [CallerLineNumber] int line = 0 | Sets the int parameter named *line* to the line number in the source code file of the statement that is executing this method that defines this parameter. |
| [CallerArgumentExpression(nameof(argumentExpression))] string expression = "" | Sets the string parameter named expression to the expression that has been passed to the parameter named *argumentExpression*.

## Types of Testing
| Type | Description |
| ------- | ----|
| Unit | Tests the smallest unit of code, typically a method or function. Unit testing is performed on a unit of code isolated from its dependencies by mocking them if needed. Each unit should have multiple tests: some with typical inputs and expected outputs, some with extreme input values to test boundaries, and some with deliberately wrong inputs to test exception handling. |
| Integration | Tests if the smaller units and larger components work together as a single piece of software. Sometimes involves integrating with external components for which you do not have source code. |
| System | Tests the whole system environment in which your software will run. |
| Performance | Tests the performance of your software; for example, your code must return a web page full of data to a visitor in under 20 milliseconds. |
| Load | Tests how many requests your software can handle simultaneously while maintaining required performance, for example, 10,000 concurrent visitors to a website. |
| User Acceptance | Tests if users can happily complete their work using your software. |

## Common Guard Clauses
| Exception | Guard Clause Methods |
| ------- | ----|
| ArgumentException | ThrowIfNullOrEmpty, ThrowIfNullOrWhiteSpace |
| ArgumentNullException | ThrowIfNull |
| ArgumentOutOfRange | ThrowIfEqual, ThrowIfGreaterThan, ThrowIfGreaterThanOrEqual, ThrowIfLessThan, ThrowIfLessThanOrEqual, ThrowIfNegative, ThrowIfNegativeOrZero, ThrowIfNotEqual, ThrowIfZero |



## Projects List
* TopLevelFunctions
* WritingFunctions
* Debugging
* HotReloading
* Instrumenting
* CalculatorLib
* CallStackExceptionHandling


## Practice Questions
1. What does the C# keyword *void* mean?  
**Answer: void means the method does not return anything**  
2. What are some differences between imperative and functional programming styles?  
**Answer: Imperative programming means writing a sequence of statements that the runtime will execute step by step like a recipe. Functional programming is declarative and describes what you want to achieve instead of how, Functional programming makes all states immutable by default to avoid side effects.**  
3. In VisualStudio what is the difference between F5, Ctrl+F5?  
**Answer: F5 will save, compile, and run the project with the debugger attached. Ctrl+F5 will save, compile, and run the project without the debugger attached. Shift+F5 stops the debugger and running application. Ctrl+Shift+F5 restarts the application without the debugger attached.**
4. Where does the Trace.WriteLine method write its output to?  
**Answer: Any configured trace listener. By default this includes the terminal and command line but can be configured to a text file or custom listener.**
5. What are the five trace levels?  
**Answer: 0 - Off, 1 - Error, 2 - Warning, 3 - Info, and 4 - Verbose**  
6. What is the difference between Debug and Trace classes?  
**Answer: Debug logging is written only during development. When running with Release configuration, only Trace will write to any Trace Listeners.**
7. When writing a unit test, what are the three "A"s?  
**Answer: Arrange, Act and Assert.**
8. When writing a unit test using xUnit, which attribute must you decorate the test methods with?  
**Answer: ```[Fact]```**
9. What dotnet command executes xUnit tests?  
**Answer: ```dotnet test```**  
10. What statement should you use to rethrow a caught exception named ex without losing the stack trace?  
**Answer: ```throw```**


## Practice Example Project Setup
1. Create a class library called Ch04Ex02PrimeFactorsLib public class Primes and public static string PrimeFactors method.
2. Create a console app called Ch04Ex02PrimeFactorsApp
3. Add project reference to the class library in Ch04Ex02PrimeFactorsApp.csproj file.
4. Build console app Ch04Ex02PrimeFactorsApp
5. In Ch04Ex02PrimeFactorsApp Program.cs add ```using Ch04Ex02PrimeFactorsLib;``` to top so we can use classes from there.
6. Use class.method() in your program, i.e.: ```Primes.PrimeFactors(2);```
7. Create xUnit Test Project called Ch04Ex02PrimeFactorsTests
8. Rename test class to PrimeFactorsUnitTests.cs
9. Set Project reference (same step as 3) > Project | Add Project Reference Ch04Ex02PrimeFactorsLab
10. Write tests
11. Build Test project
12. Run Tests
13. Debug, etc.


## My takeaways / Questions / Notes
Nice to see how functions will display parameters and VisualStudio will help you use the functions correctly.  
Watch out for silent overflow  
Do we typically build a function then another function to call that function?  
What unit testing framework do we use?  
Static methods are named as such because they are called by the static Main method.  
Void lets you know that the method will not return a value.


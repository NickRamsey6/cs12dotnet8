# Chapter 4 Summary

## Key Concepts

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


## Projects List
* TopLevelFunctions
* WritingFunctions
* Debugging
* HotReloading
* Instrumenting


## Practice Questions


## Practice Example Projects


## My takeaways / Questions / Notes
Nice to see how functions will display parameters and VisualStudio will help you use the functions correctly.  
Watch out for silent overflow  
Do we typically build a function then another function to call that function?


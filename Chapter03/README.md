# Chapter 3 Summary

## Key Concepts
* Use operators to perform simple tasks
* Use branch and loop statements to implement logic
* Work with sngle- and multi-dimensional arrays
* Convert between types
* Catch exceptions and handle integer overflow

## List Pattern Matching with Arrays
| Example | Description |
|------|-------------------|
| [] | Matches an empty array or collection |
| [..] | Matches an array or collection with any number of items, including 0, so [..] must come after [] if you need to switch on both
| [_] | Matches a list with any single item |
| [int item1] or [var item1] | Matches a list with any single item and can use the value in the return expression by reffering to item1 |
| [7, 2] | Matches exactly a list of two items with those values in that order|
| [_, _] | Matches a list with any two values |
| [var item1, var item2] | Matches a list with any two items and can use the values in the return expression by referring to item1 and item2 |
| [_, _, _] | Matches a list with any three items |
| [var item1, ..] | Matches a list with one or more items, can refer to the value of the first item in its return expression by referring to item1 |
| [var firstItem, .., var lastItem] | Matches a list with two or more items, can refer to the value of the first and last item in its return expression by referring to firstItem and lastItem |
| [.., var lastItem] | Matches a list with one or more items, can refer to the value of the last item in its return expression by referring to lastItem |

## Array Types
| Type of Array | Declaration Syntax |
|------|-------------------|
| One Dimension | datatype[], i.e. string[] |
| Two Dimensions | string[,] |
| Three Dimensions | string[,,] |
| Ten Dimensions | [,,,,,,,,,] |
| Array of arrays aka two-dimensional jagged array | string[][] |
| Array of arrays of arrays aka three-dimensional jagged array | string[][][] |


## Practice Questions
1. What happens when you divide an int variable by 0?  
**Answer: The System.DivideByZeroException is thrown**
2. What happens when you divide a double variable by 0?  
**Answer: You get infinity**
3. What happens when you overflow an int variable, that is set it to a value beyond its range?  
**Answer: OverflowException is thrown. If the OverflowException is allowed, the value starts at the minimum value for that type**
4. What is the difference between ```x = y++;``` and ```x = ++y;```  
**Answer: The first statement is using a postfix operator so the incrementing takes place after the assignment. The second statement is using a prefixed operator so the incrementation is taking place before the assignment. tldr: Statement 1: x = y + 1, Statement 2: x and y both = y + 1.**
5. What is the difference between *break*, *continue* and *return* when used inside a loop statement?  
**Answer: Break ends the loop and continues executing at that point, Continue ends the current iteratio of the loop and continues executing at the start of the loop for the next iteration, Return will end the current method call and continue executing after the method**
6. What are the three parts of a for statements and which of them is required?  
**Answer: 1. *Initializer Expression* 2. *Conditional Expression* 3. *Iterator Expression* All are optional**
7. What is the difference between the = and == operators?  
**Answer: "=" is used to assign a value, "==" is used to evaluate if an operand is equal to another operand, returning true or false.**
8. Does the following statement compile?  
``` for ( ; ; ); ```  
**Answer: Yes, it is an infinte loop**
9. What dies the underscore _ represent in a switch expression?  
**Answer: The default return value. It is also called a discard. It is used to represent a potential variable that is not needed.**
10. What interface must an object "implement" to be enumerated over by using the foreach statement?  
**Answer: The IEnumerable interface. It must have the correct methods with the correct signatures even if the object does not actually implement the interface.**


## Projects List
* Operators - Unary, Binary, Assignment, Null Coalescing, Logical, Conditional Logical, Bitwise and Shift Operators
* SelectionStatements - if/else and cases
* IterationStatements - Looping with While, Do, For, and ForEach
* Arrays - Single, Multi-Dimensional, and Jagged Arrays Plus Pattern Matching
* CastingConverting - Explicit vs Implicit Casting, Using System.Convert type, Rounding, Encoding and Parsing
* HandlingExceptions - Try/Catch Blocks, Filters, Exceptions, and Checked/Unchecked Blocks

## My takeaways
Exclamtion mark (!) is the null-forgiving operator. It disables the compiler warning and has no effect on runtime. Example:  
``` int age = int.Parse(input!); ``` 
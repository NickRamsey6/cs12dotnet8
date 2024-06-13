# Chapter 5 Summary

## Key Concepts

## Member Access Modifiers
| Member Access Modifier | Description |
| ------- | ----|
| private | The member is accessible inside the type only. This is the default. |
| internal | The member is accessible inside the type and any type in the same assembly. |
| protected | The member is accessible inside the type and any type that inherits from the type. |
| public | The member is accessible everywhere. |
| internal protected | The member is accessible inside the type, any type in the same assembly, and any type that inherits from the type. Equivalent to a fictional access modifier named *internal_or_protected* |
| private protected | The member is accessible inside the type and any type that inherits from the type and is in the same asssembly. Equivalent to a fictional access modifier named *internal_and_protected*. This combination is only available with C# 7.2 or later. |

## Projects List
* PacktLibraryNetStandard2
* PeopleApp


## Practice Questions


## My takeaways / Questions / Notes
Building a project will compile the referenced dependencies and copy the class library.dll to the local bin folder.  
Methods of a class can access properties/values of the class without needing to be passed in.  
Do we often write overloaded methods?  
Why do we use DateTimeOffset?  
Methods vs functions?  
Lambda Expression  => Like anonymous functions, you dont need to specify the type of the value that you input, thus making it more flexible.  
Why use private vs. public?  





# Chapter 5 Summary

## Key Concepts
* Making your own types using OOP
* Some of the different categories of members that a type can have, including fields to store data and methods to perform actions.
* OOP concepts like aggregation and encapsulation.
* How to use modern C# features, like relational and property pattern matching enhancements, init-only properties, and record types.

## Member Access Modifiers
| Member Access Modifier | Description |
| ------- | ----|
| private | The member is accessible inside the type only. This is the default. |
| internal | The member is accessible inside the type and any type in the same assembly. |
| protected | The member is accessible inside the type and any type that inherits from the type. |
| public | The member is accessible everywhere. |
| internal protected | The member is accessible inside the type, any type in the same assembly, and any type that inherits from the type. Equivalent to a fictional access modifier named *internal_or_protected* |
| private protected | The member is accessible inside the type and any type that inherits from the type and is in the same assembly. Equivalent to a fictional access modifier named *internal_and_protected*. This combination is only available with C# 7.2 or later. |
| file | A type can only be used within its code file. |

## Projects List
* PacktLibraryNetStandard2
* PeopleApp
* PacktLibraryModern


## Practice Questions
1. What are the seven access modifier keywords and combinations of keywords, and what do they do?  
**Answer: 1. <ins>*private*</ins> - default, accessible in type only. 2. <ins>*internal*</ins> - accessible inside the type and any type in the same assembly. 3. <ins>*protected*</ins> - accessible inside the type and any type that inherits from the type. 4. <ins>*public*</ins> - accessible everywhere. 5. <ins>*internal protected*</ins> - accessible inside the type, any type in the same assembly and any type that inherits from the type. 6. <ins>*private protected*</ins> - accessible inside the type and any type that inherits from the type and is in the same assembly. 7. <ins>*file*</ins> - accessible only within its code file.**  
2. What is the difference between static, const, and readonly keywords when applied to a type member?  
**Answer: Static members only have one value and are shared across all instances. Static members are accessed through the type. Const members are assigned a fixed literal value at compile time. To access a const field you must write the name of the class not the instance. Readonly members can only be assigned using a constructor or field initializers at runtime.**  
3. What does a constructor do?  
**Answer: Constructors allocate memory and initialize field values. Constructors are called when you make an instance of a class using the ```new``` keyword.**  
4. Why should you apply the ```[Flags]``` attribute to an enum type when you want to store combined values?  
**Answer:With the ```[Flags]``` the returned enum value will be a comma-separated list of text values.**
5. Why is the ```partial``` keyword useful?  
**Answer: Types can be split up using ```partial``` over multiple files to better organize your code.**  
6. What is a tuple?  
**Answer: a tuple is an efficient way to combine two or more values into a single unit.**
7. What does the ```record``` keyword do?  
**Answer: The ```record``` keyword makes the whole object immutable and acts like a value when compared.**  
8. What does overloading mean?  
**Answer: Overloading is when multiple methods have the same name but different signatures. This can help you simplify a class by making it appear to have less methods.**  
9. What is the difference between the following statements?  
```public List<Person> Children = new();```  
```public List<Person> Children => new();```  
**Answer: The second statement is using a Lambda expression to to define a read-oly property named Children that returns an empty list of Person objects. The first statement is defining a field named Children to an empty list of Person objects.**  
10. How do you make a method parameter optional?  
**Answer by assigning default values for each optional parameter.**   


## My takeaways / Questions / Notes
Building a project will compile the referenced dependencies and copy the class library.dll to the local bin folder.  
Methods of a class can access properties/values of the class without needing to be passed in.  
Do we often write overloaded methods?  
Why do we use DateTimeOffset?  
Methods vs functions?  - Methods are actions that an object can perform, either on itself or on related objects. 
Lambda Expression  => Like anonymous functions, you dont need to specify the type of the value that you input, thus making it more flexible.   
Switch expression uses _ to represent its default branch.  





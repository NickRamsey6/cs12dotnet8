# Chapter 6 Summary

## Key Concepts
* Operators
* Generic Types
* Delegates and Events
* Implementing Interfaces
* Memory usage differences between Reference and Value types
* Working with null values
* Deriving and casting types using inheritance
* Base and derived classes, how to override a type member, and using polymorphism

## Common Interfaces
| Interface | Method(s) | Description |
| --------- | ----------|-------------|
| IComparable | CompareTo(other) | This defines a comparison method that a type implements to order or sort its instances. |
| IComparer | Compare(first, second) | This defines a comparison method that a secondary type implements to order or sort instances of a primary type. |
| IDisposable | Dispose() | This defines a disposal method to release unmanaged resources more efficiently than waiting for a finalizer. See the *Releasing unmanaged resources* section. |
| IFormattable | ToString(format, culture) | This defines a culture-aware method to format the value of an object into a string representation. |
| IFormatter | Serialize(stream, object) Deserialize(stream) | This defines methods to convert an object to and from a stream of bytes for storage or transfer. |
| IFormatProvider | GetFormat(type) | This defines a method to format inputs based on a language and region. |


## Commonly Used Initialisms
| Initialism | Meaning | Description |
| --------- | ----------|-------------|
| NRT | Nullable Reference Type | A compiler feature introduced with C#8 and enabled by default in new projects with C#10, which performs static analysis of your code at design time and shows warnings of potential misuse of null values for reference types. |
| NRE | NullReferenceException | An exception thrown at runtime when **dereferencing** a null value, aka accessing a variable or member on an object is null. |
| ANE | ArgumentNullException | An exception thrown at runtime by a method, property, or indexer invocation when an argument or value is null, and when the business logic determines that it is not valid. |


## Categories of Custom Types and Their Capabilities
| Type | Instantiation | Inheritance | Equality | Memory |
| ---- | --------------|-------------|----------|--------|
| class | Yes | Single | Reference | Heap | 
| sealed class | Yes | None | Reference | Heap |
|abstract class | No | Single | Reference | Heap |
| record or record class | Yes | Single | Value | Heap |
| struct or record struct | Yes | None | Value | Stack |
| interface | No | Multiple | Reference | Heap |

## Projects List
* PacktLibrary - Defines the Person class and its methods
* PeopleApp - Creates new people, marriages and weddings
* NullHandling - Creating nullable value types

## Practice Questions
1. What is a delegate?  
**Answer: A delegate is a type-safe method reference. They can be used to execute any method with a matching signature. Delegates contain the memory address of a method that must match the same signature as the delegate, enabling it to be called safely within the correct parameter types. Delegates allow you to implement events to send messages between different objects that do not need to know about each other.**  
2. What is an event?  
**Answer: Events are actions that can happen to an object. Events are built on delegates and provide a way of exchanging messages between objects. An event is a field that is a delegate with the ```event``` keyword applied. Multiple delegates can be combined but must use += and -= to do so.**
3. How are a base class and a derived class related, and how can the derived class access the base class?  
**Answer: Derived class (or subclass) is a class that inherits from a base class (or superclass). Inside a derived class, you use the ```base``` keyword to access the class that the subclass inherits from.**  
4. What is the difference between ```is``` and ```as``` operators?  
**Answer: The ```is``` operator returns true if an object can be cast to the type, false if not. The ```as``` operator returns a reference to the object if an object can be cast to the type, and returns null if it cannot be cast.**
5. Which keyword is used to prevent a class from being derived from or a method from being further overridden?  
**Answer: ```sealed```**  
6. Which keyword is used to prevent a class from being instantiated with the ```new``` keyword?  
**Answer: ```abstract```**
7. Which keyword is used to allow a member to be overridden?  
**Answer: ```virtual```**
8. What's the difference between a destructor and a deconstruct method?  
**Answer: Destructor methods aka finalizer methods release resources and destroy objects in memory, they are called by .NET runtime. Deconstruct methods are used to access values stored inside objects.**
9. What are the signatures of the constructors that all exceptions should have?  
**Answer: (), (string message), and (string message, Exception innerException)**
10. What is an extension method, and how do you define one?  
**Answer: Extension methods make static methods from static classes appear to be one of the members of another type. You define which type you want to extend by prefixing the first parameter of that type in the method using the ```this``` keyword.**

## Practice Example Projects

## My takeaways / Questions / Notes
? declares a property as nullable? Tell compiler we are expecting a possible null value  
```public string? Name { get; set; }```  
What do guard clauses really do? ```ArgumentNullException.ThrowIfNull();```  
Can I get a definition of instance method? Or static method?  
Do we create our own interfaces often?  
**ASK ANDY:** pg 340 - enabling NRTs - what is going on with the constructors?   
Multiple inheritance vs. Single inheritance?  - Only interfaces support multiple inheritance





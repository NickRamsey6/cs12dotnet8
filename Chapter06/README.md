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

## Practice Example Projects

## My takeaways / Questions / Notes
? declares a property as nullable? Tell compiler we are expecting a possible null value  
```public string? Name { get; set; }```  
What do guard clauses really do? ```ArgumentNullException.ThrowIfNull();```  
Can I get a definition of instance method? Or static method?  
Do we create ouw own interfaces often?  
**ASK ANDY:** pg 340 - enabling NRTs - what is going on with the constructors?   
Multiple inheritance vs. Single inheritance?  





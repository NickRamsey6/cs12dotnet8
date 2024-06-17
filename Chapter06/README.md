# Chapter 6 Summary

## Key Concepts

## Common Interfaces
| Interface | Method(s) | Description |
| --------- | ----------|-------------|
| IComparable | CompareTo(other) | This defines a comparison method that a type implements to order or sort its intstances. |
| IComparer | Compare(first, second) | This defines a comparison method that a secondary type implements to order or sort instances of a primary type. |
| IDisposable | Dispose() | This defines a dispoal method to release unmanaged resources more efficiently than waiting for a finalizer. See the *Releasing unmanaged resources* section. |
| IFormattable | ToString(format, culture) | This defines a culture-aware method to format the value of an object into a string representation. |
| IFormatter | Serialize(stream, object) Deserialize(stream) | This defines methods to convert an object to and from a stream of bytes for storage or transfer. |
| IFormatProvider | GetFormat(type) | This defines a method to ormat inputs based on a language and region. |


## Projects List
* PacktLibrary - Defines the Person class and its methods
* PeopleApp - Creates new people, marriages and weddings

## Practice Questions

## Practice Example Projects

## My takeaways / Questions / Notes
? declares a property as nullable? Tell compiler we are expecting a possible null value  
```public string? Name { get; set; }```  
What do guard clauses really do? ```ArgumentNullException.ThrowIfNull();```  
Can I get a definition of instance method? Or static method?  
Do we create ouw own interfaces often?  



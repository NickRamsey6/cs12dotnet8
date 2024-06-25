# Chapter 8 Summary

## Key Concepts
* Choices for types to store and manipulate numbers
* Handling text, including using regular expressions for validating input
* Collections to use for storing multiple items
* Working with indexes, ranges, and spans

## Common .NET Number Types
| Namespace | Example Type(s) | Description |
|-----------|-----------------|-------------|
| System | SByte, Int16, Int32, Int64, Int128 | Integers: 0 and positive and negative whole numbers. |
| System | Byte, UInt16, UInt32, UInt64, UInt128 | Cardinals: 0 and positive whole numbers. |
| System | Half, Single, Double | Reals: Floating-point numbers. |
| System | Decimal | Accurate reals: Used in science, engineering or financials. |
| System.Numerics | BigInteger, Complex, Quarternion | Arbitrarily large integers, complex numbers and quaterion numbers. |

## Common .NET Text Types
| Namespace | Type | Description |
|-----------|-----------------|-------------|
| System | Char | Storage for a single text character |
| System | String | Storage for multiple text characters |
| System.Text | StringBuilder | Efficiently manipulates strings |
| System.Text.RegularExpressions | Regex | Efficiently pattern-matches strings |

## String Members
| Member | Description |
|--------|-------------|
| Trim, TrimStart, TrimEnd | These methods trim whitespace characters such as space, tab, and carriage return from the start and/or end. |
| ToUpper, ToLower | These convert all the characters into uppercase or lowercase. | 
| Insert, Remove | These methods insert or remove some text. |
| Replace | This replaces some text with other text. |
| string.Empty | This can be used instead of allocating memory each time you use a literal string value using an empty pair of double quotes (""). |
| string.Concat | This concatenates two string variables. The + operator does the equivalent when used between string operands. |
| string.Join | This concatenates one or more string variables with a character in between each one. |
| string.IsNullOrEmpty | This checks whether a string variable is null or empty. |
| string.IsNullOrWhiteSpace | This checks whether a string variable is null or whitespace; that is a mix of any number of horizontal and vertical spacing characters, for example, tab, space, carriage return, line feed, and so on. |
| string.Format | An alternative method to string interpolation for outputting formatted string values, which uses positioned instead of named parameters. |

## Common Regex Symbols
| Symbol | Meaning | Symbol | Meaning |
|--------|---------|--------|---------|
| ^ | Start of input | $ | End of input |
| \d | A single digit | \D | A single non-digit |
| \s | Whitespace | \S | Non-whitespace |
| \w | Word characters | \W | Non-word characters |
| [A-Za-z0-9] | Range of characters | \^ | ^ (caret) character |
| [aeiou] | Set of characters | [^aeiou] | Not in a set of characters |
| . | Any single character | \. | .(dot) character |

## Common Collection Types
| Namespace | Example type(s) | Description |
|-----------|-----------------|-------------|
| System.Collections | IEnumerable, IEnumerable<<T>T> | Interfaces and base classes used by collections. |
| System.Collections.Generic | List<<T>T>, Dictionary<<T>T>, Queue<<T>T>, Stack<<T>T> | These collections allow you to specify the tpe you want to store using a generic type parameter (which is safer, faster and more efficient). |
| System.Collections.Concurrent | BlockingCollection, ConcurrentDictionary, ConcurrentQueue | These collections are safe to use in multithreaded scenarios. |
| System.Collections.Immutable | ImmutableArray, ImmutableDictionary ImmutableList, ImmutableQueue | Designed for scenarios where the contents of the original collection will never change, although they can create modified collections as a new instance. |

## Common Set Methods
| Method | Description |
|--------|-------------|
| Add | If the item does not already exist in the set, then it is added. Returns true if the item was added, false if it was already in the set. |
| ExceptWith | Removes the items in the set passed as the parameter from the set. |
| IntersectWith | Removes the items not in the set passed as the parameter and in the set. |
| IsProperSubsetOf, IsProperSupersetOf, IsSubsetOf, IsSupersetOf | A subset is a set whose items are all in the other set but there is at least one item in the other set that is not in the set. A superset is a set that contains all the items in the other set. A proper superset is a set that contains all the items in the other set and at least one more not in the other set. |
| Overlaps | The set and the other set share at least one common item. |
| SetEquals | The set and the other set contain exactly the same items. |
| SymmetricExceptWith | Removes the items not in the set passed as the parameter from the set and adds any that are missing. |
| UnionWith | Adds any items in the set passed as the parameter to the set that are not already in the set. |

## Collection Add and Remove Methods
| Collection | "Add" Methods | "Remove" Methods | Description |
|------------|---------------|------------------|-------------|
| List | Add, Insert | Remove, RemoveAt | Lists are ordered so items have an integer index position. Add will add a new item at the end of the list. Insert will add a new item at the index position specified. |
| Dictionary | Add | Remove | Dictionaries are not ordered so items do not have integer index positions. You can check if a key has been used by calling the ContainsKey method. |
| Stack | Push | Pop | Stacks always add a new item at the top of the stack using the Push method. The first item is at the bottom. Items are always removed from the top of the stack using the Pop method. Call the Peek method to see this value without removing it. Stacks are LIFO. |
| Queue | Enqueue | Dequeue | Queues always add a new item at the end of the queue using the Enqueue method. The first item is at the front of the queue. Items are always removed from the front of the queue using the Dequeue method. Call the Peek method to see this value without removing it. Queues are FIFO. | 

## Common Auto-Sorting Collections
| Collection | Description |
|------------|-------------|
| SortedDictionary<TKey, TValue> | This represents a collection of key/value pairs that are sorted by key. Internally it maintains a binary tree for items. |
| SortedList<TKey, TValue> | This represents a collection of key-value pairs that are sorted by key. The name is misleading because this is not a list. Compared to SortedDictionary<TKey, TValue>, retrieval performance is similar, it uses less memory, and insert and remove operations are slower for unsorted data. If it is populated from sorted data, then it is faster. Internally, it maintains a sorted array with binary search to find elements. |
| SortedSet<T<T>> | This represents a collection of unique objects that are maintained in a sorted order. |

## Projects List
* WorkingWithNumbers
* WorkingWithText
* WorkingWithRegularExpressions
* WorkingWithCollections
* WorkingWithRanges
* Ch08Ex02RegularExpressions

## Practice Questions
1. What is the maximum number of characters that can be stored in a string variable?  
**Answer: Max size of a string is 2 GB, or 1 billion characters. Each character uses 2 bytes due to the internal use of Unicode (UTF-16) encoding for characters in a string.**
2. When and why should you use a SecureString type?  
**Answer: SecureString encrypts its text and ensures that the memory is released immediately. Good for working with passwords.**
3. When is it appropriate to use a StringBuilder class?  
**Answer: When concatenating more than three string variables. Also StringBuilder allows you to modify a string variable without creating a new record in memory.**
4. When should you use a LinkedList<T<T>> class?  
**Answer: Use a LinkedList when you want to reference the previous and next items in the list. Use when items need to be inserted and removed from positions in the list without moving items in memory.**
5. When should you use a SortedDictionary<T<T>> class rather than a SortedList<T<T>> class?  
**Answer: SortedList<T<T>> class uses less memory than SortedDictionary<T<T>>. SortedDictionary<T<T>> has faster insertion and removal operations for unsorted data. If list is populated all at one from sorted data, SortedList<T<T>> is faster.**
6. In a regular expression, what does $ mean?  
**Answer: $ represents the end of the input.**
7. In a regular expression, how can you represent digits?  
**Answer: \d represents digits. So does [0-9]**
8. Why should you not use the official standard for email addresses to create a regular expression to validate a user's email address?  
**Answer: The effort is not worth the pain of the users. The official specification does not check whether that address exists or whether the person entering it is the owner.**
9. What characters output when the following code runs?  
```
string city = "Aberdeen";
ReadOnlySpan<char> citySpan = city.AsSpan()[^5..^0];
WriteLine(citySpan.ToString());
```
**Answer: rdeen. ^5.. means the range is 5 characters long. ..^0 means the range ends zero characters in from the right end.**   
10. How could you check that a web service is available before calling it?  
**Answer: Use the ping class.**

 
## My takeaways / Questions / Notes
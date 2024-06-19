# Place to track my C# studies

## C# Keywords
### Value Type Keywords
| Keyword | Value Type |
|---------|------------|
| bool | Boolean Value: ```true``` or ```false``` | 
| byte | Numeric Value: 0 to 255 |
| char | Character Value: UTF-16 |
| decimal | Floating-Point Value: 16bytes |
| double | Floating-Point Value: 8bytes|
| enum | Enumeration Type |
| float | Floating-Point Value: 4bytes |
| int | Numeric Value: -2billion to 2billion |
| long | Numeric Value: -9quintillion to 9quintillion |
| sbyte | Numeric Value: -128 to 127 |
| short | Numeric Value: -32,768 to 32,767 |
| struct | Structure Type |
| uint | Numeric Value: 0 to 4billion |
| ulong | Numeric Value: 0 to 18quintillion |
| ushort | Numeric Value: 0 to 65,535|

### Reference Type Keywords
| Keyword | Definition |
|---------|------------|
| class | - | 
| delegate | Type-Safe Method Reference | 
| interface | Implement standard functionality and connect different types to make new things | 
| object | - | 
| string | Sting of characters | 
| void | Method does not return a value | 

### Modifier Keywords
| Keyword | Modification |
|---------|------------|
| public | Member is accessible everywhere | 
| private | Member is accessible inside the type only. This is **default** |
| internal | Member is accessible inside the type and any type in the same assembly |
| protected | Member is accessible inside the type and any type that inherits from the type |
| abstract | Prevents a class from being instantiated with the ```new``` keyword |
| const | - |
| event | Allows the exchanging of messages between objects |
| extern | - |
| new | Instantiates a new instance  |
| override | Overrides, or redefines a method or property |
| partial | Allows a class, struct, record or interface to be split into multiple files  |
| readonly | Assignment to this field can only occur as part of declaration or in constructor |
| sealed | Prevents a class from being derived from or a method from being overridden |
| static | Member belongs to the type itself rather than a specific object |
| unsafe | Required for pointers or working with unmanaged types |
| virtual | Member can be overridden |
| volatile | - |  

### Statement Keywords
| Keyword | Use |
|---------|------------|
| if | Conditional: if this then do this... | 
| else | Conditional: pairs with if, can be used alone or with ```else if``` | 
| switch | Compares a single expression against a list of mulitple case statements | 
| do | Loop: executes 1 or more times while a boolean expression is true | 
| for | Loop: requires an initializer, a condition and an iterator | 
| foreach | Loop: requires a type with a method named GetEnumerator that returns an object, the returned object needs to have a property called Current and a method named MoveNext, the MoveNext method must change the value of Current and return true if there are more items to enumerate through | 
| in | Used with ```foreach x in listOfX``` | 
| while | Loop: executes 0 or more times as long as a specified boolean expression returns true  | 
| break | Ends the loop and continues executing at that point | 
| continue | Ends the current iteration of the loop and continues executing at the start of the loop with the next iteration | 
| goto | Used with switch to move to another case | 
| return | Ends the current method call and continue executing after the method | 
| throw | Throws an exception | 
| try | Attempts to execute code block works with catch to handle exceptions  | 
| catch | Catch exceptions so alternate code is run instead of just breaking | 
| finally | Used with try to execute code when control leaves the try block | 
| checked | Prevents overflow of integral-type arithmetic operations | 
| unchecked | Allows overflow of integral-type arithmetic operations | 

### Method Parameter Keywords
| Keyword | Definition |
|---------|------------|
| params | - | 
| in | - | 
| ref | - | 
| out | - | 

### Namespace Keywords
| Keyword | Definition |
|---------|------------|
| namespace | - | 
| using | - | 
| extern | - | 

### Operator Keywords
| Keyword | Definition |
|---------|------------|
| as | Returns a reference to the object if an object can be cast to the type and null if it can't | 
| is | Returns true if an object can be cast to the type | 
| new | Instantiates a new instance | 
| sizeof | - | 
| typeof | - | 
| true | - | 
| false | - | 
| stackalloc | - | 

### Conversion Keywords
| Keyword | Definition |
|---------|------------|
| explicit | - | 
| implicit | - | 
| operator | - | 

### Access Keywords
| Keyword | Definition |
|---------|------------|
| base | The base class that the current object inherits from  | 
| this | The current object instance | 

### Literal Keywords
| Keyword | Definition |
|---------|------------|
| null | - | 
| default | - | 

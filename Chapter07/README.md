# Chapter 7 Packaging and Distributing .NET Types

## Key Concepts
* Journey of .NET 8 for BCL Functionality
* Relationship Between Assemblies and Namespaces
* Publishing an App for Distribution on Multiple Operating Systems
* Publish to Native AOT
* Decompile .NET Assemblies
* Package and Distribute a Class Library
* Activate Preview Features

## Example Assemblies and Their Namespaces
| Assembly | Example Namespaces | Example Types |
|----------|--------------------|---------------|
| System.Runtime.dll | System, System.Collections, System.Collections.Generic | Int32, String, IEnumerable<T> |  
| System.Console.dll | System | Console |  
| System.Threading.dll | System.Threading | Interlocked, Monitor, Mutex |
| System.Xml.XDocument.dll | System.Xml.Linq | XDocument, XElement, XNode |

## Some Important Packages
| Package | Important Types |
|---------|-----------------|
| System.Runtime | Object, String, Int32, Array |
| System.Collections | List<T<T>>, Dictionary<TKey, TValue> |
| System.Net.Http | HttpClient, HttpResponseMessage |
| System.IO.Filesystem | File, Directory |
| System.Reflection | Assembly, TypeInfo, MethodInfo |

## Practice Questions
1. What is the difference between a namespace and an assembly?  
**Answer: Namespace is the address of a type. Assembly is where a type is stored in the filesystem. To use the type, must reference its assembly. Or can import its namespace or specify the namespace when specifying the type.**
2. How do you reference another project in a .csproj file?  
**Answer: By adding a <Project Reference<Project Reference>> element that sets the Include attribute to a path to the reference project file inside an ItemGroup element.**
3. What is the benefit of a tool like ILSpy?  
**Answer: ILSpy can let you see how other packages are written. Can also help you understand how third-party libraries should be used. ILSpy lets you decompile code.**
4. Which .NET type does the C# float alias represent?  
**Answer: System.Single**
5. When porting an application from .NET Framework to modern .NET, what tool should you run before porting and what tool could you run to perform much of the porting work?  
**Answer: .NET Portability Analyzer before porting. .NET Upgrade Assistant to perform porting work.**
6. What is the difference between framework-dependent and self-contained deployments of .NET applications.  
**Answer: Framework-dependent modern .NET applications require .NET to be installed fo an operating system to execute. Self-contained .NET applications include everything necessary to execute on their own.**
7. What is a RID?  
**Answer: Runtime Identifier.**
8. What is the difference between dotnet pack and dotnet publish commands?  
**Answer: dotnet pack creates a NuGet package. dotnet publish puts the application and its dependencies into a folder for deployment.**
9. What types of applications written for .NET Framework can be ported to modern .NET?  
**Answer: Console, ASP.NET MVC, ASP.NET Web API, Windows Forms, Windows Presentation Foundation apps.**
10. Can you use packages written for .NET Framework with modern .NET?  
**Answer: Yes, if they only call APIs in .NET Standard 2.0.**

## My takeaways / Questions / Notes






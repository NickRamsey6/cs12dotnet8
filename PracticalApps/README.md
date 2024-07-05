# Chapters 12-15 Web Development

## Chapter 12 Introducing Web Development Using ASP.NET Core

### Key Concepts
* Introduction to some of the app models you can use to build websites and web services using C# and .NET
* Create class libraries to define an entity data model for working with Northwind database using SQLite

### Know Your Abbreviations
| Abbreviation | Stands For | Definition |
|--------------|------------|-------------|
| URI | Uniform Resource Identifier | A unique sequence of characters that identifies a resource.
| URL | Unique Resource Locator | The address of a unique resource. |
| WCF | Windows Communication Foundation | A framework for building service-oriented applications. Part of .NET Framework, WCF Core available for modern .NET |
| TLD | Top Level Domain | One of the domains at the highest level in the hierarchial DNS (Domain Name System) of the internet, for example espn.com. |
| API | Application Programming Interface | A mechanism for a computer system to allow other computer systems to communicate with it.
| SPA | Single Page Application | A web app that loads only a single web page then updates the content dynamically via JavaScript APIs when needed. Angular, React, Vue, Blazor. |
| CMS | Content Management System | A software application that allows users to build and manage a website without having to write code. |
| Wasm | WebAssembly | A binary instruction format designed as a compilation target for programming languages, like C#, for deployment on the web, on the client, and server. |
| SASS | Syntactically Awesome Style Sheets | A CSS preprocessor. Has features that dont exist in CSS like nesting, mixins and inheritance that help you write maintainable CSS. |
| REST | REpresentational State Transfer | An architectural style for distributed hypermedia systems. | 


### Practice Questions
1. What was the name of Microsoft's first dynamic server-side-executed web page technology and why is it still useful to know this history today?  
**Answer: Active Server Pages (ASP). That's where the ASP in ASP.NET Core comes from. ASP is still used in some some features like Tag Helpers.**
2. What are the names of two Microsoft web servers?  
**Answer: IIS (Windows-only) and Kestrel (Cross-platform).**
3. What are some differences between a microservice and a nanoservice?  
**Answer: Nanoservices have a single function, and are inactive until called upon. Microservices have more than one function and are always running.**
4. What is Blazor?  
**Answer: A framework for building UI components using C# and .NET instead of Angular, React, etc. It is designed for single-page applications (SPAs).**
5. What was the first version of ASP.NET Core that could not be hosted on .NET Framework?  
**Answer: ASP.NET Core 3.0 requires .NET Standard 2.1 which is not supported by .NET Framework.**
6. What is a user agent?  
**Answer: A client web server. Examples: a web browser, or a search engine web crawler.**
7. What impact does the HTTP request-response communication model have on web development?  
**Answer: Website dynamic code resides on and executes on a web server. The server code cannot trigger communication. A web browser must make an HTTP request to trigger code on the server, which can then generate an HTTP response. This makes updating a web page difficult because it is under the control of the client, not the server.**
8. Name and describe four components of a URL.  
**Answer: 1. Scheme: http for clear text and https for encrypted. This is how the request is sent to the server. 2. Domain: the unique web address aka espn.com is the Top Level Domain for the URL. 3. Path: a relative path to a resource i.e. /customers. 4. Query String: a way to pass parameters to the server i.e. ?county=usa.**
9. What capabilities does Developer Tools give you?  
**Answer: Allows you to see every HTTP request and response, view client-side application data like cookies, sessions and local storage, provides a console for logging, and so on.**
10. What are the three main client-side web development technologies and what do they do?  
**Answer: 1. HTML5 - the content and structure of a web page. 2. CSS3 - the styles applied to elements on the web page. 3. JavaScript - code for any business logic needed on the web page.**


## Chapter 13 Building Websites Using ASP.NET Core Razor Pages

### Key Concepts

### Common Build Actions for ASP.NET Core Project Files
| Build Action | Description |
|--------------|-------------|
| AdditionalFiles | Provides inputs to analyzers to verify code quality. |
| Compile or C# compiler | Passed to the compiler as a source file. |
| Content | Included as part of the website when its deployed. |
| Embedded Resource | Passed to the compiler as a resource to be embedded in the assembly. |
| None | Not part of the build. This value can be used for documentation and other files that should not be deployed with the website. |


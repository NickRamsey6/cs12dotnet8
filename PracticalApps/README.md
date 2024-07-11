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
* The foundations of web development using HTTP
* How to build a simple website that returns static files
* How to use ASP.NET Core Razor Pages with Entity Framework Core to create web pages that are dynamically generated from information in a database
* How to configure the HTTP request and response pipeline, what the helper extension methods do and how you can add your own middleware that affects processing

### Common Build Actions for ASP.NET Core Project Files
| Build Action | Description |
|--------------|-------------|
| AdditionalFiles | Provides inputs to analyzers to verify code quality. |
| Compile or C# compiler | Passed to the compiler as a source file. |
| Content | Included as part of the website when its deployed. |
| Embedded Resource | Passed to the compiler as a resource to be embedded in the assembly. |
| None | Not part of the build. This value can be used for documentation and other files that should not be deployed with the website. |

### Common Methods That Register Dependency Services
| Method | Service Registered |
|--------|--------------------|
| AddMvcCore | Minimum set of services necessary to route requests and invoke controllers. Most websites will need more configuration than this. |
| AddAuthorization | Authentication and authorization services. |
| AddDataAnnotations | MVC data annotations service. |
| AddCacheTagHelper | MVC cache tag helper service. |
| AddRazorPages| Razor Pages service, including the Razor view engine. Commonly used in simple website projects. It calls the following additional methods: AddMvcCore, AddAuthorization, AddDataAnnotations, AddCacheTagHelper |
| AddApiExplorer | Web API explorer service. |
| AddCors | Cross-origin resource sharing (CORS) support for enhanced security. |
| AddFormatterMappings | Mappings between a URL format its corresponding media type. |
| AddControllers | Controller services but not services for views or pages. Commonly used in ASP.NET Core Web API projects. It calls the following additional methods: AddMvcCore, AddAuthorization, AddDataAnnotations, AddCacheTagHelper, AddApiExplorer, AddCors, AddFormatterMappings |
| AddViews | Support for .cshtml views including default conventions. |
| AddRazorViewEngine | Support for the Razor view engine including processing the @ symbol. |
| AddControllersWithViews | Controller, view, and page services. Commonly used in ASP.NET Core MVC website projects. It calls the following additional methods: AddMvcCore, AddAuthorization, AddDataAnnotations, AddCacheTagHelper, AddApiExplorer, AddCors, AddFormatterMappings, AddViews, AddRazorViewEngine
| AddMvc | Similar to AddControllersWithViews, but you should only use it for backward compatibility. 
| AddDbContext<T<T>> | Your DbContext type and its optional DbContextOptions<TContext<T>>.
| AddNorthwindContext | A custom extension method we created to make it easier to register the NorthwindContext class for either SQLite or SQL server based on the project referenced. |

### Key Middleware Extension Methods
| Method | Description |
|--------|-------------|
| UseHsts | Adds middleware for using HSTS, which add the Strict-Transport-Security header. |
| UseHttpsRedirection | Adds middleware for redirecting HTTP requests to HTTPS, so in our code a request for http://localhost:5130 would receive a 307 response telling the browser to request https://localhost:5131. |
| UseDefaultFiles | Adds middleware that enables default file mapping on the current path, so in our code it would identify files such as index.html or default.html. |
| UseStaticFiles | Adds middleware that looks in wwwroot for static files to return in the HTTP response. |
| MapRazorPages | Adds middleware that will map URL paths such as /suppliers to a Razor Page file in the /Pages folder named suppliers.cshtml and return the results as the HTTP response. |
MapGet | Adds middleware that will map URL paths such as /hello to an inline delegate that writes text directly to the HTTP response. |
| UseRouting | Adds middleware that defines a point in the pipeline where routing decisions are made and must be combined with a call to UseEndpoints where processing is then executed. |
| UseEndpoints | Adds middleware to execute to generate responses from decisions made earlier in the pipeline. |

### Practice Questions
1. List six method names that can be specified in an HTTP request.  
**Answer: GET, HEAD, POST, PUT, DELETE**
2. List six status codes and their descriptions that can be returned in an HTTP response.  
**Answer: 200 OK, 201 Created, 301 Moved Permanently, 400 Bad Request, 404 Not Found (missing resource), and 500 Internal Server Error.**
3. In ASP.NET Core, what is the Program class used for?  
**Answer: Program class is where you add and configure dependency services like Razor Pages, MVC, and Entity Framework Core data contexts. It is also where you configure middleware in the request and response pipeline. This might include error handling, security options, static files, default files, and endpoint routing.**
4. What does the acronym HSTS stand for and what does it do?  
**Answer: HTTP Strict Transport Security. If a website specifies it and the browser support it, then it forces all communication over HTTPS and prevents the visitor from using untrusted or invalid certificates.**
5. How do you enable static HTML pages for a website?  
**Answer:**
```
app.UseDefaultFiles();
app.UseStaticFiles();
```
6. How do you mix C# code into the middle of HTML to create a dynamic page?  
**Answer: Create a Razor file with the .cshtml extension and then prefix any C# expressions with the @ symbol, and for C# statements, wrap them in braces or create @functions sections.**
7. How can you define shared layouts for Razor Pages?  
**Answer: Create two files: *_Layout.cshtml* to define the markup for the shared layout and *_ViewStart.cshtml* to set the default layout.**
```
@{
    Layout = "_layout";
}
```
8. How can you separate the markup from the code-behind in a Razor Page?  
**Answer: Create two files: *MyPage.cshtml* containing the markup and *MyPage.cshtml.cs* containing a class that inherits from PageModel.InMyPage.cshtml. Set the model to use the class like this:**
```
@page
@model MyProject.Pages.PageModel
```
9. How do you configure an Entity Framework Core data context for use with an ASP.NET Core website?  
**Answer: Reference the assembly that defines the data context class in your project file. Import the namespaces for Microsoft.EntityFrameworkCore and the data context class in Program.cs or the Startup class. Add a statement that configures the data context with a database connection string for use with a specified database provider in your ConfigureServices method or Program.cs. In the Razor Page model class or @functions section, declare a private filed to store data context and then set it in the constructor.**
10. How can you reuse Razor Pages with ASP.NET Core 2.2 or later?  
**Answer: Compile everything related to a Razor Page into a class library.**
```
dotnet new razorclasslib -s
```

## MVC

### Models, Views and Controllers
**Models** - Classes that represent the data entities and view models used on the website.  
**Views** - Razor views (.cshtml files) that render data in view models into HTML web pages. Razor views are not Razor pages. Razor views must NOT have the @Page directive.  
**Controllers** - Classes that execute code when an HTTP request arrives at the web server. Controller methods usually instantiate a view model and pass that to a view to generate an HTTP response. This is returned to the web browser or other client that made the original request. 

### Builder Object
Has two commonly used methods: Configuration and Services  
`Configuration` - contains merged values from aa the places you could set configuration: `appsettings.json`, environment variables, command-line arguments and so on.  
`Services` - collection of registered dependency services. The call to AddDbContext is an example of registering a dependency service. ASP.NET Core implements the dependency injection (DI) design pattern so that other components like controllers can request needed services through their constructors. 

### The Default MVC Route
Route - discovers the name of a controller class to instantiate and an action method to execute, with an optional id parameter to pass into the method that will generate an HTTP response.  
Segments - Curly brackets in a route pattern. Like named parameters of a method. Can be any string and are NOT case sensitive.  
Route pattern looks at a URL path requested by the browser and matches it to the exact name of a controller, then name of an action, and an optional id value (`?` makes it optional).  
Default is Home for controller and Index for action.  

### Example URLs and Default Routing
| URL | Controller | Action | ID |
|-----|------------|--------|----|
| / | Home | Index | |
| /Muppet | Muppet | Index | |
| /Muppet/Kermit | Muppet | Kermit | |
| /Muppet/Kermit/Green | Muppet | Kermit | Green |
| /Products | Products | Index | |
| /Products/Detail | Products | Detail | |
| /Products/Detail/3 | Products | Detail | 3 |

### ControllerBase Properties for Working With the Current HTTP Context
| Property | Description |
|----------|-------------|
| `Request` | Just the HTTP request, headers, query string params, body of the request as a stream you can read from, content type and length, and cookies. |
| `Response` | Just the HTTP response, headers, body of the response as a stream that you can write to, content type and length, status code, and cookies. Also delegates like `OnStarting` and `OnCompleted` that you can hook a method up to. |
| `HttpContext` | Everything about the current HTTP context including the request and response, connection information, collection of features that have been enabled on the server with middleware, and a `User` object for authentication and authorization. |

### Controller Properties
| Property | Description |
|----------|-------------|
| `ViewData` | A dictionary in which the controller can store key/value pairs that is accessible in a view. The dictionary's lifetime is only for the current request/response. |
| `ViewBag` | A dynamic object that wraps `ViewData` to provide a friendlier syntax for setting and getting dictionary values. |
| `TempData` | A dictionary in which the controller can store key/value pairs that is accessible in a view. The dictionary's lifetime is for the current request/response and the next request/response for the same visitor session. Useful for storing a value during an initial request, responding with a redirect, and then reading the stored value in the subsequent request. |

### Controller Methods
| Method | Description |
|--------|-------------|
| `View` | Returns a `ViewResult` after executing a view that renders a full response, for example, a dynamically generated web page. The view can be selected using a convention or be specified with a `string` name. A model can be passed to the view. |
| `PartialView` | Returns a `PartialViewResult` after executing a view that is part of a full response, for example a dynamically generated chunk of HTML. The view can be selected using a convention or be specified with a string name. A model can be passed to the view. |
| `ViewComponent` | Returns a `ViewComponentResult` after executing a component that dynamically generates HTML. The component must be selected by specifying its type or its name. An object can be passed as an argument. | 
| `Json` | Returns a `JsonResult` containing a JSON-serialized object. This can be useful for implementing a simple Web API as part of an MVC controller that primarily returns HTML for a human to view. |

### Reponsibilities of a Controller
* Identify the services that the controller needs to be in a valid state and to function properly in their class constructor(s).
* Use the action name to identify a method to execute. 
* Extract parameters from the HTTP request. 
* Use the parameters to fetch any additional data needed to construct a view model and pass it to the appropriate view for the client. 
* Return the results from the view to the client as an HTTP response with an appropriate status code. 

### Models
**Models** represent the data required to respond to a request. Two types commonly used are Entity models and View models.  
**Entity Models** represent entities in a database like SQL Server or SQLite. One or more entities might need to be retrieved from data storage. Entity models are defined using classes, since they might need to change and then be used to update the underlying data store.  
**View Models** aka MVC model. All the data that we want to show in response to a request. The model that is passed into a view for rendering into a response format like HTML or JSON. Should be immutable so commonly defined using the record type.

### Cache Busting with Tag Helpers
When `asp-append-version` is specified with a `true` value in a `link`, `img`, or `script` element, the Tag Helper for that tag type is invoked. Tag helpers automatically append a query string value named `v` that is generated from a SHA256 hash. If even a single byte within the file with the Tag Helper changes, the hash will be different and a browser that cached the old file will be busted and replaced with the newer version.

### MVC Chapter Review Questions
1. What do files with the special names _ViewStart and _ViewImports do when created in the views folder?  
**Answer: _*ViewStart* contains statements that are executed when the View method is executed, like when a controller action method passes a model to a view to set a default layout.  
_ViewImports contains @using statements to import namespaces for all views to avoid having to add the same import statements at the top of all views.**
2. What are the names of the three segments defined in the default ASP.NET Core MVC route, what do they represent, and which are optional?  
**Answer: {controller} - represents a controller class to instantiate. Optional because it can use the default value: Home. {action} - represents an action method. Optional because it can use the default value: Index. {id} - represents a parameter in the action method. Optional because it is suffixed with ?.**
3. What does the default model binder do and what data types can it handle?  
**Answer: Default model binder sets parameters in the action method. Can handle simple types like int, string, DateTime, (nullable types also) complex types and collection types.**
4. In a shared layout file like _Layout.cshtml, how do you output the content of the current view?  
**Answer: Call the RenderBody method to output the content of the current view in a shared layout. `@RenderBody()`**
5. In a shared layout file like _Layout.cshtml, how do you output a section that the current view can supply content for and how does the view supply the contents of that section.  
**Answer: Call the RenderSection method and specify the name of the section if it is required:
```@RenderSection("Scripts", required: false)```  
To define the contents of a section in the view, create a named section:**
```
@section Scripts
{
    <script>
        alert('Hello, Mr. Page!');
    </script>
}
```
6. When calling the View method inside a controller's action method, what paths are searched for the view by convention?  
**Answer: Thee paths are searched by default:** 
* /Views/[controller]/[action].cshtml
* /Views/Shared/[action].cshtml
* /Pages/Shared/[action].cshtml
7. How can you instruct the visitor's browser to cache the response for 24 hours?  
**Answer: Decorate the controller class or action method with the [ResponseCache] attribute, and set the duration to 86400 seconds and the location parameter to ResponseCacheLocation.Client.**
8. Why might you enable Razor Pages even if you are not creating any yourself?  
**Answer: ASP.NET Core Identity UI requires Razor Pages.**
9. How does the ASP.NET Core MVC identify classes tht can act as controllers?  
**Answer: By looking to see if the class (or the class it derives from) is decorated with the [Controller] attribute.**
10. In what ways does the ASP.NET Core MVC make it easier to test a website?  
**Answer: The Model-View-Controller design pattern separates the technical concerns. Makes it easier to write unit tests. ASP.NET Core also makes it easy to implement the Inversion-of-Control (IoC) and dependency injection (DI) design patterns to remove dependencies when testing a component like a controller. Model is the shape of the data. Controller has the executable statements to process the incoming request and outgoing response. View is the generation of the response in a format requested by the user agent like HTML or JSON.**
 
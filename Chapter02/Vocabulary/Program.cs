//using System.Reflection; //To use Assembly, Typename and so on.

//// Declare some unused variables using types in additional assemblies to make them load too
//System.Data.DataSet ds = new();
//HttpClient Client = new();

//// Get the assembly that is the entry point for this app
//Assembly? myapp = Assembly.GetEntryAssembly();

//// If the previous line returned nothing then end the app
//if (myapp is null) return;

//// Loop through the assemblies that my app references
//foreach (AssemblyName name in myapp.GetReferencedAssemblies())
//{
//    // Load the assembly so we can read its details
//    Assembly a = Assembly.Load(name);

//    // Declare a variable to count the number of methods
//    int methodCount = 0;

//    // Loop through all the types in the assembly
//    foreach (TypeInfo t in a.DefinedTypes)
//    {
//        // Add up the counts of all the methods
//        methodCount += t.GetMethods().Length;
//    }

//    // Output the count of types and their methods
//    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
//        arg0: a.DefinedTypes.Count(),
//        arg1: methodCount,
//        arg2: name.Name);
//}

double heightInMetres = 1.88;
WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");


//// See https://aka.ms/new-console-template for more information
////#error version
//Console.WriteLine("Hello, World!");
////WriteLine($"Computer named {Env.MachineName} says \"No.\"");
//WriteLine();
//WriteLine("Hello Ahmed");
//WriteLine(
//    "Temperature on {0:D} is {1}*C.", DateTime.Today, 23.4);


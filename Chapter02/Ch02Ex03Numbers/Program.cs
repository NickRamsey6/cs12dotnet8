// This namespace provides the Marshal class used below
using System.Runtime.InteropServices;

// Standard solution, print the name, sizeof, MinValue and MaxValue for each data type
// Types are hardcoded
// Alignment formatting used to format output as a table
unsafe
{
    Console.WriteLine();
    Console.WriteLine($"Type    {"Byte(s) of memory",-4} {"Min",32} {"Max",45}");
    Console.WriteLine($"sbyte {sizeof(sbyte),15} {sbyte.MinValue,37} {sbyte.MaxValue,45}");
    Console.WriteLine($"byte {sizeof(byte),15} {byte.MinValue,37} {byte.MaxValue,45}");
    Console.WriteLine($"short {sizeof(short),15} {short.MinValue,37} {short.MaxValue,45}");
    Console.WriteLine($"ushort {sizeof(ushort),15} {ushort.MinValue,37} {ushort.MaxValue,45}");
    Console.WriteLine($"int {sizeof(int),15} {int.MinValue,37} {int.MaxValue,45}");
    Console.WriteLine($"uint {sizeof(uint),15} {uint.MinValue,37} {uint.MaxValue,45}");
    Console.WriteLine($"long {sizeof(long),15} {long.MinValue,37} {long.MaxValue,45}");
    Console.WriteLine($"ulong {sizeof(ulong),15} {ulong.MinValue,37} {ulong.MaxValue,45}");
    Console.WriteLine($"Int128 {sizeof(Int128),15} {Int128.MinValue,37} {Int128.MaxValue,45}");
    Console.WriteLine($"UInt128 {sizeof(UInt128),15} {UInt128.MinValue,37} {UInt128.MaxValue,45}");
    Console.WriteLine($"Half {sizeof(Half),15} {Half.MinValue,37} {Half.MaxValue,45}");
    Console.WriteLine($"float {sizeof(float),15} {float.MinValue,37} {float.MaxValue,45}");
    Console.WriteLine($"double {sizeof(double),15} {double.MinValue,37} {double.MaxValue,45}");
    Console.WriteLine($"decimal {sizeof(decimal),15} {decimal.MinValue,37} {decimal.MaxValue,45}");
}

// Refactor to use list of data types to programtically loop through and print name, sizeof, MinValue and MaxValue
unsafe
{
    // typeof operator sets these values as their System.Type objects at compile time
    // These objects have access to the important Properties and Fields I need
    var typesList = new[] { typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(decimal) };
    Console.WriteLine();
    Console.WriteLine($"Type    {"Byte(s) of memory",-4} {"Min",32} {"Max",45}");
    foreach (var type in typesList)
    {
        Console.WriteLine(
            "{0} {1, 10} {2, 42} {3, 50}",
            // Need to access the name property on the type object
            // Otherwise you get "System.SByte"
            type.Name,
            // Variables can not be used as types (even if they kind of are them)
            // So I needed to create a type instance of my variables so I could use the SizeOf method
            Marshal.SizeOf(Activator.CreateInstance(type)),
            // the type object has the fields min and max value so I can access them here
            // Need to use GetValue ontop of GetField because it neeeds to be deconstructed
            type.GetField("MinValue").GetValue(null),
            type.GetField("MaxValue").GetValue(null));
    }
}


// The structs Half, Int128 and UInt128 have their min and max values as properties instead of fields
// Best practice might be to combine and use a try catch or exception handler to check for fields, if not found then check for properties
unsafe
{
    var typesList = new[] { typeof(Half), typeof(Int128), typeof(UInt128) };
    Console.WriteLine();
    Console.WriteLine($"Type    {"Byte(s) of memory",-4} {"Min",32} {"Max",45}");
    foreach (var type in typesList)
    {
        Console.WriteLine(
            "{0} {1, 10} {2, 42} {3, 50}",
            type.Name,
            Marshal.SizeOf(Activator.CreateInstance(type)),
            type.GetProperty("MinValue").GetValue(null),
            type.GetProperty("MaxValue").GetValue(null)
            );
    }
}

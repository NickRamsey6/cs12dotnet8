// array of number types that we want to find the bytes of memory, min and max for
// Loop through array and print to console thier stats
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


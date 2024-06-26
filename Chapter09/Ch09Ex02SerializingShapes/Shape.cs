using System.Xml.Serialization;

namespace Packt.Shared;

// These are needed or exception will be thrown
[XmlInclude(typeof(Circle))]
[XmlInclude(typeof(Rectangle))]

public abstract class Shape
{

    // Create Properties - Area is READONLY
    public string? Color { get; set; }
    public abstract double Area { get; }
    public double Width { get; set; }
    public double Height { get; set; }

    // Parameterless constructor
    public Shape() { }
}
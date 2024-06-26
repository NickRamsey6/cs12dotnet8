using System.Xml.Serialization; // To use XmlSerializer
using Packt.Shared; // To use Shape, Rectangle, and Circle classes

// Create a list of Shapes to serialize
List<Shape> listOfShapes = new()
{
    new Circle { Color = "Red", Radius = 2.5},
    new Rectangle { Color = "Blue", Height = 20.0, Width = 10.0 },
    new Circle { Color = "Green", Radius = 8.0 },
    new Circle { Color = "Purple", Radius = 12.3 },
    new Rectangle { Color = "Blue", Height = 45.0, Width = 18.0 }
};

// Preserialize
WriteLine("Preserialize!");
foreach (Shape shape in listOfShapes)
{
    WriteLine("{0} is {1} and has an area of {2:N2}",
        shape.GetType().Name, shape.Color, shape.Area);
}

WriteLine("Loading Shapes from XML:");
// Create serializer to format list of Shapes as XML
XmlSerializer xs = new(type: listOfShapes.GetType());

// Create a file to write to
string path = Combine(CurrentDirectory, "shapes.xml");

using (FileStream stream = File.Create(path))
{
    // Serialize the object graph to the stream
    xs.Serialize(stream, listOfShapes);
}

// Deserialize
using (FileStream xmlLoad = File.Open(path, FileMode.Open))
{
    // Deserialize and cast the object graph into a List of Shapes
    List<Shape>? loadedShapesXml =
        xs.Deserialize(xmlLoad) as List<Shape>;

    if (loadedShapesXml is not null)
    {
        foreach (Shape item in loadedShapesXml)
        {
            WriteLine("{0} is {1} and has an area of {2:N2}",
                item.GetType().Name, item.Color, item.Area);
        }
    }
}


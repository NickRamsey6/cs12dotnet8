namespace Packt.Shared;

public class Shape
{
    // Define shape properties
    public virtual double Height { get; set; }
    public virtual double Width { get; set; }
    public virtual double Area { get; set; }

    // NEED a method to set the Area property
    public static double FindArea(float Height,  float Width)
    {
        return Height * Width;
    }
}

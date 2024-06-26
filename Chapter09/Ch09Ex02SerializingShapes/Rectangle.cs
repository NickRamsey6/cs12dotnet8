namespace Packt.Shared;

public class Rectangle : Shape
{
    // Override the Area property with Rectangle Area formula
    public override double Area
    {
        get
        {
            return Height * Width;
        }
    }
}
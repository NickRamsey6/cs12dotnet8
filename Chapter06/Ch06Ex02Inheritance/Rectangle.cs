namespace Packt.Shared;

public class Rectangle : Shape
{
    // Rectangle constructor to initialize Shape properties Height and width
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Override the Area field inherited from the Shape class with a rectangle-specific calculation for Area
    public override double Area
    {
        get
        {
            // Area = L * W
            return Width * Height;
        }
    }
}
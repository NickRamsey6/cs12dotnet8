namespace Packt.Shared;

public class Circle : Shape
{
    // Define Circle-specific Radius property 
    public double Radius { get; set; }
    
    // Circle constructor to initialize circle fields
    public Circle(double radius)
    {
        Width = radius * 2;
        Height = radius * 2;
        Radius = radius;
    }

    // Override the Shape Area with Circle-specific calculation
    public override double Area
    {
        get
        {
            // Area = Pi * Radius ^2
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}
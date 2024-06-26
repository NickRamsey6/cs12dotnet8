namespace Packt.Shared;

public class Circle : Shape
{
    // Create the circle-specific Radius property
    public double Radius { get; set; }

    //Override the Area property inherited from Shape
    public override double Area
    {
        get
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}

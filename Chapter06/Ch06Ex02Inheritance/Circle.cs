namespace Packt.Shared;

public class Circle : Shape
{
    public virtual double Radius { get; set; }
    public Circle() { }

    public Circle(double radius)
    {
        this.Width = radius * 2;
        this.Height = radius * 2;
        this.Radius = radius;
    }

    public new void FindArea(Circle c1)
    {
        c1.Area = 3.14* (c1.Radius * c1.Radius);
    }
}
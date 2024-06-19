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

    public void FindArea(Circle c1)
    {
        c1.Area = Math.PI * (Math.Pow(c1.Radius, 2));
    }
}
namespace Packt.Shared;

public class Square : Shape
{
    public virtual double Side { get; set; }
    public Square() { }

    public Square(double side)
    {
        this.Width = side;
        this.Height = side;
        this.Side = side;
    }

    public void FindArea(Square sq1)
    {
        sq1.Area = Math.Pow(sq1.Side, 2);
    }
}
using Packt.Shared;

Rectangle r = new(height: 3, width: 4.5);
r.FindArea(r);
Console.WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}.");

Square s = new(5);
s.FindArea(s);
Console.WriteLine($"Square H: {s.Height}, W: {s.Width}, Area: {s.Area}");

Circle c = new(radius: 2.5);
c.FindArea(c);
Console.WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area: {c.Area}");
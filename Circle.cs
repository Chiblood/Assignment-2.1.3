public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(int id, string name, string color, double radius) : base(id, name, color)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
public abstract class Shape(int id, string name, string color)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Color { get; set; } = color;
    public abstract double CalculateArea();
}
namespace task1;

public abstract class Shape
{
    string? _description;
    public abstract double  CalculateArea();
    public virtual string PrintDescription()
    {
        return $"Description of the shape.";
    }
}

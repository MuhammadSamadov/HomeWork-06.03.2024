namespace task1;

public class Circle : Shape
{
    double _radius;
    double _pi=3.14;
    public Circle(double radius)
    {
        _radius=radius;
    }
    public override double CalculateArea()
    {
        return _radius*_radius*_pi;
    }
    public override string PrintDescription()
    {
        return $"Description of the Circle. {_radius*_radius*_pi}";
    }

}

namespace task2;

public class Bus : IMovable
{
    string? _color;
    double _speed;
    string? _model;
    public Bus(string color , double speed,string model)
    {
        _color=color;
        _speed=speed;
        _model=model;
    }
    public string MoveLeft()
    {
        return "The car is moving left";
    }
    public string MoveRight()
    {
        return "The car is moving righ";
    }
}

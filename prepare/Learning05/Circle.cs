using System;


public class Circle : Shape
{
    private double _side;
    public Circle(string color, double side): base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}
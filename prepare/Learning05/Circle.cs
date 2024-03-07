using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius): base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return (_radius * _radius) * Math.PI;
    }
}
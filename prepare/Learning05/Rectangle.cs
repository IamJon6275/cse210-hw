using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public class Rectangle : Shape
{
    private double _shortSide;
    private double _longSide;
    public Rectangle(string color, double shortSide, double longSide) : base(color)
    {
        _shortSide = shortSide;
        _longSide = longSide;
    }

    public override double GetArea()
    {
        return _shortSide * _longSide;
    }
}
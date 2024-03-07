using System;

public class Shape
{
    private string _color;

    //getter
    public string GetColor()
    {
        return _color;
    }

    //setter
    public void SetColor(string color)
    {
        _color = color;
    }

    //constructor
    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return -1;
    }
}
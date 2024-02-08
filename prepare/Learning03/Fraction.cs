using System;

public class Fraction
{
    private int _top;
    private int _bottom;
    public void fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public void fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public void fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    // public int GetTop()
    // {
    //     return _top;
    // }
    // public void SetTop(int top)
    // {
    //     _top = top;
    // }
    // public int GetBottom()
    // {
    //     return _bottom;
    // }
    // public void SetBottom(int bottom)
    // {
    //     _bottom = bottom;
    // }
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double top = _top;
        double bottom = _bottom;
        double decVal = top / bottom;
        return decVal;
    }
}
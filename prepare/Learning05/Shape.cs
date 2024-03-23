using System;

public class Shape
{
    protected string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }

    public string GetColor()
    {
        return color;
    }
}

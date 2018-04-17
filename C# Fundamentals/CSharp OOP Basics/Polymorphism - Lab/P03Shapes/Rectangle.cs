using System;


public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return Width * 2 + Height * 2;
    }

    public override string Draw()
    {
        return base.Draw();
    }
}


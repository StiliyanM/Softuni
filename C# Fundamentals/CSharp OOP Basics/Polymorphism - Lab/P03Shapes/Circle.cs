﻿using System;

public class Circle : Shape
{
    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public double Radius { get; set; }

    public override double CalculateArea() => Math.PI * this.Radius * this.Radius;

    public override double CalculatePerimeter() => 2 * Math.PI * this.Radius;

    public override string Draw()
    {
        return base.Draw();
    }

}


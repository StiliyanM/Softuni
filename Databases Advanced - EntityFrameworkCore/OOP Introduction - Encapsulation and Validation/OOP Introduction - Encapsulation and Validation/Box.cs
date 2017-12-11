using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get
        {
            return this.length;
        }
        private set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }
    public double Width
    {
        get
        {
            return this.width;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }
    public double Height
    {
        get
        {
            return this.height;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this.height = value;
        }
    }


    public Box(double height,double width, double length)
    {
        this.Height = height;
        this.Width = width;
        this.Length = length;
    }

    public double GetSurfaceArea()
    {
        double surfaceArea = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        return surfaceArea;
    }

    public double GetLateralSurfaceArea()
    {
        double lateralSurfaceArea = 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        return lateralSurfaceArea;
    }

    public double GetVolume()
    {
        double volume = this.Height * this.Width * this.Length;

        return volume;
    }
}


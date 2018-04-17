using System;

class Box
{
    private const string valueZeroOrNegativeMessage = "{0} cannot be zero or negative.";
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
            if (value <= 0)
            {
                throw new ArgumentException(string.Format(valueZeroOrNegativeMessage,"Length"));
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
                throw new ArgumentException(string.Format(valueZeroOrNegativeMessage, "Width"));
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
                throw new ArgumentException(string.Format(valueZeroOrNegativeMessage, "Height"));
            }

            this.height = value;
        }
    }


    public Box(double height, double width, double length)
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


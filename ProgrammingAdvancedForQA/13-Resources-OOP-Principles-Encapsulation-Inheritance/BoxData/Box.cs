using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BoxData;

public class Box
{
    private double _length;
    private double _width;
    private double _height;

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Heigth = height;
    }
    
    public double Length
    {
        get { return _length; }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException($"Length cannot be zero or negative.");
            }
            _length = value;
        }
    }
    public double Width
    {
        get { return _width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Width cannot be zero or negative.");
            }
            _width = value;
        }
    }
    public double Heigth
    {
        get { return _height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Height cannot be zero or negative.");
            }
            _height = value;
        }
    }

    static void SurfaceArea(double length, double width, double heigth)
    {
        double sum = 2 * length * width + 2 * length * heigth + 2 * width * heigth;

        Console.WriteLine($"Surface Area – {sum:f2}");
    }

    static void Volume(double length, double width, double heigth)
    {
        double volume = length * width  * heigth;
        Console.WriteLine($"Volume - {volume:f2}");
    }


}

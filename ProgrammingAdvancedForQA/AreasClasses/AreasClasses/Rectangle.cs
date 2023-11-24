using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasClasses
{
    internal class Rectangle
    {
        public double a { get; set; }
        public double b { get; set; }

        public double Area(double a, double b)
        {
            double area = a * b;
            return area;
        }
    }
}
